using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEgov.Model
{
    public class ServiceMedOrg
    {
        public static bool removePatientFromMedOrg(int medOrgId, int patientId)
        {
            using (LiteDatabase db = new LiteDatabase("med.db"))
            {
                var pam = db.GetCollection<PatientAddedMed>("PatientAddedMed");
                var result = pam.Delete(f => f.medOrgId == medOrgId && f.patientId == patientId);


                if (result > 0)
                    return true;
                else return false;
            }

        }

        public static bool addPatientFromMedOrg(int medOrgId, int patientId)
        {
            using (LiteDatabase db = new LiteDatabase("med.db"))
            {
                var pam = db.GetCollection<PatientAddedMed>("PatientAddedMed");
                PatientAddedMed p = new PatientAddedMed();

                return true;
            }

        }

        public static List<MedOrg> getMedOrg()
        {
            using (LiteDatabase db = new LiteDatabase("med.db"))
            {
                var medOrg = db.GetCollection<MedOrg>("MedOrg");
                return medOrg.FindAll().ToList();
            }
        }
        public static void addMedOrg(MedOrg mOrg)
        {
            using (LiteDatabase db = new LiteDatabase("med.db"))
            {
                var medOrg = db.GetCollection<MedOrg>("MedOrg");
                medOrg.Insert(mOrg);
            }
        }
    }
}
