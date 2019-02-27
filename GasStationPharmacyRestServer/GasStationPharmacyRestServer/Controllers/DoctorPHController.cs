using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GasStationPharmacyRestServer.Models;
using System.Web.Http.Cors;

namespace GasStationPharmacyRestServer.Controllers
{
    public class DoctorPHController : ApiController
    {
        // GET: api/Doctor
        public List<Doctor> Get()
        {
            return DoctorRegister.GetInstance().GetAllPhischelDoctors();
        }

        // GET: api/Doctor/5
        public Doctor Get(int id)
        {
            return DoctorRegister.GetInstance().GetPhischelDoctor(id);
        }

        // POST: api/Doctor
        public HttpResponseMessage Post([FromBody]Doctor value)
        {
            DoctorRegister.GetInstance().AddPhischelDoctor(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("DoctorPH/{0}", value.Doctor_DID));
            return response;
        }

        // PUT: api/Doctor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doctor/5
        public void Delete(int doc_id)
        {
            DoctorRegister.GetInstance().RemovePhischelDoctor(doc_id);
        }
    }
}
