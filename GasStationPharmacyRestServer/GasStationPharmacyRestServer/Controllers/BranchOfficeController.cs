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
    [EnableCors(origins: "http://localhost:63786", headers: "*", methods: "*")]

    [RoutePrefix ("api/BranchOffices")]
    public class BranchOfficeController : ApiController
    {

//----------------------------------- Physchel ------------------------------------------------------

        // GET: api/BranchOffices/PH
        [Route ("PH")]
        public List<BranchOffice> GetAllPhyschelBO()
        {
            return BranchOfficeRegister.GetInstance().GetAllBOPhyschel();
        }

        // GET: api/BranchOffices/PH/{name}
        [Route ("PH/{name}")]
        public BranchOffice GetPhyschelBOByName(string name)
        {
            return BranchOfficeRegister.GetInstance().GetBOPhyschel(name);
        }

        // POST: api/BranchOffices/PH/NewClient
        [Route("PH/NewBranchOffice")]
        public HttpResponseMessage PostNewPhischelBO([FromBody]BranchOffice value)
        {
            BranchOfficeRegister.GetInstance().AddBOPhyschel(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("BranchOffice/{0}", value.BranchOffice_Name));
            return response;
        }
        // PUT: api/BranchOffices/PH/{name}/UpdateBOAdmi
        [Route("PH/{name}/UpdtaeBOAdmi")]
        public void UpdatePhichelBOAdmi(string name, [FromBody]string value)
        {
            BranchOfficeRegister.GetInstance().UpdateBOPHAdmin(BranchOfficeRegister.GetInstance().GetBOPhyschel(name), value);
        }

        // DELETE: api/BranchOffices/PH/DeleteBO/{name}
        [Route ("PH/DeleteBO/{name}")]
        public void DeletePhyschelBO(string name)
        {
            BranchOfficeRegister.GetInstance().RemoveBOPhyschel(name);
        }

        //------------------------------------------------- La Bomba ---------------------------------------------------------------------------------------------------------------------

        // GET: api/BranchOffices/PH
        [Route("BH")]
        public List<BranchOffice> GetAllLaBombaBO()
        {
            return BranchOfficeRegister.GetInstance().GetAllBOPhyschel();
        }

        // GET: api/BranchOffices/PH/{name}
        [Route("LB/{name}")]
        public BranchOffice GetLaBombaBOByName(string name)
        {
            return BranchOfficeRegister.GetInstance().GetBOLaBomba(name);
        }

        // POST: api/BranchOffices/PH/NewClient
        [Route("LB/NewBranchOffice")]
        public HttpResponseMessage PostNewLaBombaBO([FromBody]BranchOffice value)
        {
            BranchOfficeRegister.GetInstance().AddBOLaBomba(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("BranchOffice/{0}", value.BranchOffice_Name));
            return response;
        }
        // PUT: api/BranchOffices/PH/{name}/UpdateBOAdmi
        [Route("LB/{name}/UpdtaeBOAdmi")]
        public void UpdateLaBombaBOAdmi(string name, [FromBody]string value)
        {
            BranchOfficeRegister.GetInstance().UpdateBOLBAdmin(BranchOfficeRegister.GetInstance().GetBOLaBomba(name), value);
        }

        // DELETE: api/BranchOffices/PH/DeleteBO/{name}
        [Route("PH/DeleteBO/{name}")]
        public void DeleteLaBombaBO(string name)
        {
            BranchOfficeRegister.GetInstance().RemoveBOLaBomba(name);
        }
    }
}
