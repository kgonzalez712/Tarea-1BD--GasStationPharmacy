using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models
{
    public class Medicine
    {
        public string Medicine_Name { get; set; }
        public char Medicine_Require_Prescription { get; set; }
        public int Medicine_Quantity { get; set; }
    }
}