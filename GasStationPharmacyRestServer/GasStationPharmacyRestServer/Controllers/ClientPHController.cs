using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GasStationPharmacyRestServer.Models;

namespace GasStationPharmacyRestServer.Controllers
{
    public class ClientPHController : ApiController
    {
        // GET: api/Client
        public List<Client> Get()
        {
            return ClientRegister.GetInstance().getAllPhischelClients();
        }

        // GET: api/Client/5
        public Client Get(int id)
        {
            return ClientRegister.GetInstance().GetPhischelClient(id);
        }

        // POST: api/Client
        public HttpResponseMessage Post([FromBody]Client value)
        {
            ClientRegister.GetInstance().AddPhischelClient(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Client/{0}", value.Client_ID));
            return response;
        }

        // PUT: api/ClientPH/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
            ClientRegister.GetInstance().RemovePhischelCLient(id);
        }
    }
}
