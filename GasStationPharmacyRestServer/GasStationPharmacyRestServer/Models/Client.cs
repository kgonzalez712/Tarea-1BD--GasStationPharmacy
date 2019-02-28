using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models

{
    public class Client
    {
       
        public long Client_ID { get; set; }
        public string Client_First_Name { get; set; }
        public string Client_Last_Name { get; set; }
        public DateTime Client_Birthday { get; set; }
        public string Client_Address { get; set; }
        public string Client_Additional_Information { get; set; }
        public int Client_Phone_Number { get; set; }
        public string Account_Email { get; set; }
        public string Account_Password { get; set; }

        public List<Medicine> medList;

        public Client()
        {
            medList = new List<Medicine>();
        }

    }
}