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
    public class MedicineLBController : ApiController
    {
        public class MedicinePHController : ApiController
        {
            // GET: api/Medicine
            public List<Medicine> Get()
            {
                return MedicineRegister.GetInstance().GetAllMedicinesLaBomba();
            }

            // GET: api/Medicine/5
            public Medicine Get(string name)
            {
                return MedicineRegister.GetInstance().GetMedicineLaBomba(name);
            }

            // POST: api/Medicine
            public HttpResponseMessage Post([FromBody]Medicine value)
            {
                MedicineRegister.GetInstance().AddMedicineLaBomba(value);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                response.Headers.Location = new Uri(Request.RequestUri, String.Format("Medicine/{0}", value.Medicine_Name));
                return response;
            }

            // PUT: api/Medicine/5
            public void Put(int id, [FromBody]string value)
            {
            }

            // DELETE: api/Medicine/5
            public void Delete(string name)
            {
                MedicineRegister.GetInstance().RemoveMedicineLaBomba(name);
            }
        }
    }
}
