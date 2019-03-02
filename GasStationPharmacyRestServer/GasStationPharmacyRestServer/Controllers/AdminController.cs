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

    [RoutePrefix("api/Admins")]
    public class AdminController : ApiController
    {
        // -------------------------------------------- PHISCHEL ---------------------------------------------------------------------------------
        // GET: api/Admins/PH
        [Route("PH")]
        public List<Administrator> GetAllPhischelClients()
        {
            return AdminRegister.GetInstance().getAllPhyschelAdmins();
        }


        // GET: api/Client/PH/5/MedicineList
        [Route("PH/{id}")]
        public Administrator GetPhischellAdminById(int id)
        {
            return AdminRegister.GetInstance().GetPhyschelAdmin(id);

        }
        // POST: api/Admin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Admin/5
        public void Delete(int id)
        {
        }
    }
}
