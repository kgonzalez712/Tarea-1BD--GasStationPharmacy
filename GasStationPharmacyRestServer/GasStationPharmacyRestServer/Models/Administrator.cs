using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models
{
    public class Administrator
    {
        public long Admin_ID { get; set; }
        public string Admin_First_Name { get; set; }
        public string Admin_Last_Name { get; set; }
        public DateTime Admin_Birthday { get; set; }
        public string Admin_Address { get; set; }
        public int Admin_Phone_Number { get; set; }
        public string Account_Email { get; set; }
        public string Account_Password { get; set; }

    }
}