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
    public class DoctorLBController : ApiController
    {
        // GET: api/Doctor
        public List<Doctor> Get()
        {
            return DoctorRegister.GetInstance().GetAllLaBombaDoctors();
        }

        // GET: api/Doctor/5
        public Doctor Get(int id)
        {
            return DoctorRegister.GetInstance().GetLaBombaDoctor(id);
        }

        // POST: api/Doctor
        public HttpResponseMessage Post([FromBody]Doctor value)
        {
            DoctorRegister.GetInstance().AddLaBombaDoctor(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("DoctorLB/{0}", value.Doctor_DID));
            return response;
        }

        // PUT: api/DoctorLB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doctor/5
        public void Delete(int doc_id)
        {
            DoctorRegister.GetInstance().RemoveLaBombaDoctor(doc_id);
        }
    }
}
