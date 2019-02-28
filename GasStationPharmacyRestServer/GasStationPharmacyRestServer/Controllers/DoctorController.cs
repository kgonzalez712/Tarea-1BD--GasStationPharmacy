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
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]

    [RoutePrefix("api/Doctors")]
    public class DoctorController : ApiController
    {

        // -------------------------------------------- PHISCHEL ---------------------------------------------------------------------------------

        // GET: api/Doctors/PH
        [Route("PH")]
        public List<Doctor> GetAllPhischelDoctors()
        {
            return DoctorRegister.GetInstance().GetAllPhischelDoctors();
        }

        // GET: api/Doctors/PH/5
        [Route("PH/{id}")]
        public Doctor GetPischellDoctorByID(int id)
        {
            return DoctorRegister.GetInstance().GetPhischelDoctor(id);
        }

        // POST: api/Doctors/NewDoctor
        [Route("PH/NewDoctor")]
        public HttpResponseMessage Post([FromBody]Doctor value)
        {
            DoctorRegister.GetInstance().AddPhischelDoctor(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("DoctorPH/{0}", value.Doctor_DID));
            return response;
        }

        // PUT: api/Doctors/PH/{id}/UpdateDoctorFirstName
        [Route("PH/{id}/UpdateDoctorFirstName")]
        public void UpdatePhischelDoctorFN(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdatePhischelDoctorFirstName(DoctorRegister.GetInstance().GetPhischelDoctor(id), value);
        }

        // PUT: api/Doctors/PH/{id}/UpdateDoctorLastName
        [Route("PH/{id}/UpdateDoctorLastName")]
        public void UpdatePhischelDoctorLN(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdatePhischelDoctorLastName(DoctorRegister.GetInstance().GetPhischelDoctor(id), value);
        }


        // PUT: api/Doctors/PH/{id}/UpdateDoctorLastName
        [Route("PH/{id}/UpdateDoctorAddress")]
        public void UpdatePhischelDoctorAD(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdatePhischelDoctorAddress(DoctorRegister.GetInstance().GetPhischelDoctor(id), value);
        }

        // PUT: api/Doctors/PH/{id}/UpdateDoctortBirthDate
        [Route("PH/{id}/UpdateDoctorBirthDate")]
        public void UpdatePhischelDoctorBD(int id, [FromBody]DateTime value)
        {
            DoctorRegister.GetInstance().UpdatePhischelDoctorBirthDate(DoctorRegister.GetInstance().GetPhischelDoctor(id), value);
        }

        // DELETE: api/Doctors/PH/5
        [Route("LB/DeleteDoctor/{id}")]
        public void DeletePhischelDoctor(int doc_id)
        {
            DoctorRegister.GetInstance().RemovePhischelDoctor(doc_id);
        }


        //----------------------------------- La Bomba -------------------------------------------------------------------------

        // GET: api/Doctors/LB
        [Route("Lb")]
        public List<Doctor> Get()
        {
            return DoctorRegister.GetInstance().GetAllLaBombaDoctors();
        }

        // GET: api/Doctors/LB/5
        [Route("LB/{id}")]
        public Doctor Get(int id)
        {
            return DoctorRegister.GetInstance().GetLaBombaDoctor(id);
        }

        // POST: api/Doctors/LB/NewDoctor
        [Route("LB/NewDoctor")]
        public HttpResponseMessage PostNewLaBombaDoctor([FromBody]Doctor value)
        {
            DoctorRegister.GetInstance().AddLaBombaDoctor(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("DoctorLB/{0}", value.Doctor_DID));
            return response;
        }

        // PUT: api/Doctors/LB/{id}/UpdateDoctorFirstName
        [Route("LB/{id}/UpdateDoctorFirstName")]
        public void UpdateLaBombaDoctorFN(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdateLaBombaDoctorFirstName(DoctorRegister.GetInstance().GetLaBombaDoctor(id), value);
        }

        // PUT: api/Doctors/LB/{id}/UpdateDoctorLastName
        [Route("LB/{id}/UpdateDoctorLastName")]
        public void UpdateLaBombaDoctorLN(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdateLaBombaDoctorLastName(DoctorRegister.GetInstance().GetLaBombaDoctor(id), value);
        }


        // PUT: api/Doctors/LB/{id}/UpdateDoctorAddress
        [Route("LB/{id}/UpdateDoctorAddress")]
        public void UpdateLaBombaDoctorAD(int id, [FromBody]string value)
        {
            DoctorRegister.GetInstance().UpdateLaBombaDoctorAddress(DoctorRegister.GetInstance().GetLaBombaDoctor(id), value);
        }

        // PUT: api/Doctors/PH/{id}/UpdateDoctortBirthDate
        [Route("PH/{id}/UpdateDoctorBirthDate")]
        public void UpdateLaBombaDoctorBD(int id, [FromBody]DateTime value)
        {
            DoctorRegister.GetInstance().UpdateLaBombaDoctorBirthDate(DoctorRegister.GetInstance().GetLaBombaDoctor(id), value);
        }

        // DELETE: api/Doctors/PH/5
        [Route("LB/DeleteDoctor/{id}")]
        public void DeleteLaBombaDoctor(int doc_id)
        {
            DoctorRegister.GetInstance().RemoveLaBombaDoctor(doc_id);
        }
    }
}
