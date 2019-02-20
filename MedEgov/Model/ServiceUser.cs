using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace MedEgov.Model
{
    public class ServiceUser
    {
        public bool updateUserMedOrg(int medOrgId, int userId)
        {
            using (LiteDatabase db = new LiteDatabase("Med.db"))
            {
                var patients = db.GetCollection<Patient>("Patient");
                var patient = patients.FindById(userId);
               
            }
        }
    }
}
