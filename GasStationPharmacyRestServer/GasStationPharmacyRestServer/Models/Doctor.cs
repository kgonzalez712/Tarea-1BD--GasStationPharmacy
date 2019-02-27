using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models
{
    public class Doctor
    {
        public long Doctor_ID { get; set; }
        public long Doctor_DID { get; set; }
        public string Doctor_First_Name { get; set; }
        public string Doctor_Last_Name { get; set; }
        public DateTime Doctor_Birthday { get; set; }
        public string Doctor_Address { get; set; }
    }
}