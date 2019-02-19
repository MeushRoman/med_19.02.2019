using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEgov.Model
{
    public enum RequestStatus { create, approve, reject}
    public class Request
    {
        public int id { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        public DateTime processDate { get; set; }
        public Patient patient = null;
        public int patientId { get; set; }
        public int medOrgId { get; set; }
        public MedOrg medOrg = null;
        public RequestStatus requestStatus { get; set; }
    
        public Request()
        {
            patient = new Patient();
            medOrg = new MedOrg();
        }


    }
}
