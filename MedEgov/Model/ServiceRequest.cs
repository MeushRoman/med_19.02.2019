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
        public void createRequest(Request r)
        {
            try
            {
                db.createRequest(r);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }
    }
}
