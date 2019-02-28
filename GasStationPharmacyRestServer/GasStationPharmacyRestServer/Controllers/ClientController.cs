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

    [RoutePrefix("api/Clients")]
    public class ClientController : ApiController
    {
        

// -------------------------------------------- PHISCHEL ---------------------------------------------------------------------------------


        // GET: api/Clients/PH
        [Route ("PH")]
        public List<Client> GetAllPhischelClients()
        {
            return ClientRegister.GetInstance().getAllPhischelClients();
        }


        // GET: api/Client/PH/5/MedicineList
        [Route("PH/{id}/MedicineList")]
        public List<Medicine> GetPhischellClientMedListById(int id)
        {
            return ClientRegister.GetInstance().GetPhichelClientMedicineList(id);
        }

        // GET: api/Client/PH/5
        [Route("PH/{id}")]
        public Client GetPhischellClientById(int id)
        {
            return ClientRegister.GetInstance().GetPhischelClient(id);
        }

        // POST: api/Client/PH/NewClient
        [Route("PH/NewClient")]
        public HttpResponseMessage PostNewPhischelCLient([FromBody]Client value)
        {
            ClientRegister.GetInstance().AddPhischelClient(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Client/{0}", value.Client_ID));
            return response;
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/FirstName
        [Route("PH/{id}/UpdateClientInfo/FirstName")]
        public void UpdatePhichelClientFN(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientFirstName(ClientRegister.GetInstance().GetPhischelClient(id),value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/LastName
        [Route("PH/{id}/UpdateClientInfo/LastName")]
        public void UpdatePhischelClientLN(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientLastName(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/Address
        [Route("PH/{id}/UpdateClientInfo/Address")]
        public void UpdatePhischelClientAD(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientAddress(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/AdditionalInfo
        [Route("PH/{id}/UpdateClientInfo/AdditionalInfo")]
        public void UpdatePhischelClientAI(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientInfo(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/BirthDate
        [Route("PH/{id}/UpdateClientInfo/Birthdate")]
        public void UpdatePhischelClientBD(int id, [FromBody]DateTime value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientBirthDate(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/PhoneNo
        [Route("PH/{id}/UpdateClientInfo/PhoneNo")]
        public void UpdatePhischelClientPN(int id, [FromBody]int value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientPhone(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/Email
        [Route("PH/{id}/UpdateClientInfo/Email")]
        public void UpdatePhischelClientEmail(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientEmail(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/UpdateClientInfo/Password
        [Route("PH/{id}/UpdateClientInfo/Password")]
        public void UpdatePhischelClientPassword(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdatePhischelClientEmail(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/AddMed
        [Route("PH/{id}/AddMed")]
        public void AddPhischelClientMedicine(int id, [FromBody]Medicine value)
        {
            ClientRegister.GetInstance().AddPhischelClientMed(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/RemoveMed
        [Route("PH/{id}/RemoveMed")]
        public void RemovePhischelClientMedicine(int id, [FromBody]Medicine value)
        {
            ClientRegister.GetInstance().AddPhischelClientMed(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/Checkout
        [Route("PH/{id}/Checkout")]
        public void CheckoutPhischel(int id)
        {
            ClientRegister.GetInstance().CheckoutPhischell(ClientRegister.GetInstance().GetPhischelClient(id));
        }

        // DELETE: api/Client/PH/DeleteClient
        [Route("PH/DeleteClient/{id}")]
        public void DeletePhischelClient(int id)
        {
            ClientRegister.GetInstance().RemovePhischelCLient(id);
        }


// -------------------------------------------- LA BOMBA ---------------------------------------------------------------------------------

        // GET: api/Clients/LB
        [Route("LB")]
        public List<Client> GetAllLaBombaCliensts()
        {
            return ClientRegister.GetInstance().getAllLaBombaClients();
        }

        // GET: api/Client/LB/5
        [Route("LB/{id}")]
        public Client GetLaBombaClientById(int id)
        {
            return ClientRegister.GetInstance().GetLaBombaClient(id);
        }

        // GET: api/Client/LB/5/MedicineList
        [Route("LB/{id}/MedicineList")]
        public List<Medicine> GetLaBombaClientMedlistById(int id)
        {
            return ClientRegister.GetInstance().GetLaBombaClientMedicineList(id);
        }

        // POST: api/Client/LB/NewClient
        [Route("LB/NewClient")]
        public HttpResponseMessage PostNewLaBombaCLient([FromBody]Client value)
        {
            ClientRegister.GetInstance().AddLaBombaClient(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Client/{0}", value.Client_ID));
            return response;
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/FirstName
        [Route("LB/{id}/UpdateClientInfo/FirstName")]
        public void UpdateLaBombaClientFN(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientFirstName(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/LastName
        [Route("LB/{id}/UpdateClientInfo/LastName")]
        public void UpdateLaBombaClientLN(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientLastName(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/Address
        [Route("LB/{id}/UpdateClientInfo/Address")]
        public void UpdateLaBombaClientAD(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientAddress(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/AdditionalInfo
        [Route("LB/{id}/UpdateClientInfo/AdditionalInfo")]
        public void UpdateLaBombaClientAI(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientInfo(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/BirthDate
        [Route("LB/{id}/UpdateClientInfo/Birthdate")]
        public void UpdateLaBombaClientBD(int id, [FromBody]DateTime value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientBirthDate(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/PhoneNo
        [Route("LB/{id}/UpdateClientInfo/PhoneNo")]
        public void UpdateLaBombaClientPN(int id, [FromBody]int value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientPhone(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/Email
        [Route("LB/{id}/UpdateClientInfo/Email")]
        public void UpdateLaBombaClientEmail(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientEmail(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/LB/{id}/UpdateClientInfo/Email
        [Route("LB/{id}/UpdateClientInfo/Password")]
        public void UpdateLaBombaClientPassword(int id, [FromBody]string value)
        {
            ClientRegister.GetInstance().UpdateLaBombaClientEmail(ClientRegister.GetInstance().GetLaBombaClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/AddMed
        [Route("LB/{id}/AddMed")]
        public void AddLaBombaClientMedicine(int id, [FromBody]Medicine value)
        {
            ClientRegister.GetInstance().AddLaBombaClientMed(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/RemoveMed
        [Route("LB/{id}/RemoveMed")]
        public void RemoveLaBombaClientMedicine(int id, [FromBody]Medicine value)
        {
            ClientRegister.GetInstance().RemoveLaBombaClientMed(ClientRegister.GetInstance().GetPhischelClient(id), value);
        }

        // PUT: api/Clients/PH/{id}/Checkout
        [Route("LB/{id}/Checkout")]
        public void CheckoutLaBomba(int id)
        {
            ClientRegister.GetInstance().CheckoutLaBomba(ClientRegister.GetInstance().GetPhischelClient(id));
        }

        // DELETE: api/Client/LB/DeleteClient
        [Route("LB/DeleteClient/{id}")]
        public void DeleteLaBombaClient(int id)
        {
            ClientRegister.GetInstance().RemoveLaBombaClient(id);
        }
    }
}
