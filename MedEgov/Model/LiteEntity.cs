using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using MedEgov.Model;

namespace MedEgov.Model
{
    class LiteEntity
    {
        private LiteDatabase db = null;
        public LiteEntity()
        {
            db = new LiteDatabase("Med.db");
        }
        public void createRequest(Request r)
        {
            var request = db.GetCollection<Request>("request");
            request.Insert(r);
        }   
        public List<Request> getRequest()
        {
            var request = db.GetCollection<Request>("request");
            return request.FindAll().ToList();
        }
        public List<Request> getRequest(int id)
        {
            var request = db.GetCollection<Request>("request");
            return request.FindAll().Where(w=>w.id==id).ToList();
        }
        public List<Request> getRequestByPatientId(int id)
        {
            var request = db.GetCollection<Request>("request");
            return request.FindAll().Where(w => w.patientId == id).ToList();
        }

        //public List<Request> getRequestByPatientId(int id)
        //{
        //    var request = db.GetCollection<Request>("request");
        //    return request.FindAll().Where(w => w.patientId == id).ToList();
        //}

        public void updateRequest(Request r)
        {
            var request = db.GetCollection<Request>("request");
            request.Update(r);
        }


    }
}
