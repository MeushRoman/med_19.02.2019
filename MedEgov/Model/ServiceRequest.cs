using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace MedEgov.Model
{
    class ServiceRequest
    {
        private LiteEntity db = new LiteEntity();
        public Logger logger = LogManager.GetCurrentClassLogger();
        public bool createRequest(Request r)
        {
            try
            {
                db.createRequest(r);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }
        public List<Request> getUserRequest(int id)
        {
            return db.getRequestByPatientId(id);
        }

        public List<Request> getMedRequest(int id)
        {
            return db.getRequestByMedOrgId(id);
        }
        public void changeRequestStatus(Request request)
        {
            switch (request.requestStatus)
            {
                case RequestStatus.create:
                   
                    break;
                case RequestStatus.approve:
                    {
                        //1. получение организации пользователя
                        if (request.patient.medOrg != null)
                        {
                            int medOrgId = request.patient.medOrg.id;
                            int patientId = request.patientId;
                            ServiceMedOrg.removePatientFromMedOrg(medOrgId, patientId);
                        }
                        ServiceMedOrg.addPatientFromMedOrg(request.medOrgId, request.patientId);
                    }
                    break;
                case RequestStatus.reject:
                    db.updateRequest(request);
                    break;
                default:
                    break;
            }
        }
    }
}
