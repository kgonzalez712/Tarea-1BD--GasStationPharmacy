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

    [RoutePrefix("api/Medicines")]
    public class MedicineController : ApiController
    {
        // GET: api/Medicines/PH
        [Route ("PH")]
        public List<Medicine> GetAllPhischelMed()
        {
            return MedicineRegister.GetInstance().GetAllMedicinesPhyschel();
        }

        // GET: api/Medicines/PH/5
        [Route ("PH/{id}")]
        public Medicine GetPhischelMedById(string name)
        {
            return MedicineRegister.GetInstance().GetMedicinePhyschel(name);
        }

        // POST: api/Medicines/PH/NewMed
        [Route ("PH/NewMed")]
        public HttpResponseMessage PostPhischelMed([FromBody]Medicine value)
        {
            MedicineRegister.GetInstance().AddMedicinePhyschel(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Medicine/{0}", value.Medicine_Name));
            return response;
        }

        // PUT: api/Medicines/PH/{name}/UpdateQuantity
        [Route ("PH/{name}/UpdateQuantity")]
        public void PutUpdatePhischelMedinceQuantity( string name, [FromBody]int value)
        {
            MedicineRegister.GetInstance().UpdatePhischelMedQuant(MedicineRegister.GetInstance().GetMedicinePhyschel(name), value);
        }

        // DELETE: api/Medicines/PH/{name}/DeleteMedicine
        [Route("PH/{name}/DeleteMedicine")]
        public void DeletePhischelMedicine(string name)
        {
            MedicineRegister.GetInstance().RemoveMedicinePhyschel(name);
        }


        //--------------------------------------- La Bomba -----------------------------------------------------------------------------------

        // GET: api/Medicines/LB
        [Route("LB")]
        public List<Medicine> GetAllLaBombaMed()
        {
            return MedicineRegister.GetInstance().GetAllMedicinesLaBomba();
        }

        // GET: api/Medicines/LB/{name}
        [Route("LB/{id}")]
        public Medicine GetLaBombaMedById(string name)
        {
            return MedicineRegister.GetInstance().GetMedicineLaBomba(name);
        }

        // POST: api/Medicines/LB/NewMed
        [Route("LB/NewMed")]
        public HttpResponseMessage PostLaBombaMed([FromBody]Medicine value)
        {
            MedicineRegister.GetInstance().AddMedicineLaBomba(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Medicine/{0}", value.Medicine_Name));
            return response;
        }

        // PUT: api/Medicines/LB/{name}/UpdateQuantity
        [Route("LB/{name}/UpdateQuantity")]
        public void PutUpdateLaBombaMedinceQuantity(string name, [FromBody]int value)
        {
            MedicineRegister.GetInstance().UpdateLaBombaMedQuant(MedicineRegister.GetInstance().GetMedicineLaBomba(name), value);
        }

        // DELETE: api/Medicines/LB/{name}/DeleteMedicine
        [Route("LB/{name}/DeleteMedicine")]
        public void DeleteLaBombaMedicine(string name)
        {
            MedicineRegister.GetInstance().RemoveMedicineLaBomba(name);
        }

    }
}
