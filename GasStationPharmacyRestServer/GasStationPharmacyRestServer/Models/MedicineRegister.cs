using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GasStationPharmacyRestServer.Models;

namespace GasStationPharmacyRestServer.Models
{
    public class MedicineRegister
    {
        List<Medicine> medListPH;
        List<Medicine> medListLB;

        static MedicineRegister med_reg = null;




        private MedicineRegister()
        {
            medListPH = new List<Medicine>();
            medListLB = new List<Medicine>();

            Medicine a = new Medicine();

            a.Medicine_Name = "Paracetamol";
            a.Medicine_Require_Prescription = 'n';
            a.Medicine_Quantity = 100;

            medListPH.Add(a);
            medListLB.Add(a);
        }

        public static MedicineRegister GetInstance()
        {
            if (med_reg == null)
            {
                med_reg = new MedicineRegister();
                return med_reg;
            }
            else
            {
                return med_reg;
            }
        }


        public void AddMedicinePhyschel(Medicine med)
        {
            medListPH.Add(med);
        }

        public String RemoveMedicinePhyschel(string name)
        {
            for (int i = 0; i < medListPH.Count; i++)
            {
                Medicine m = medListPH.ElementAt(i);
                if (m.Medicine_Name.Equals(name))
                {
                    medListPH.RemoveAt(i);
                    return "Medicine successfully deleted";
                }
            }
            return "There's no medicine registered to that name";

        }

        public Medicine GetMedicinePhyschel(string name)
        {
            for (int i = 0; i < medListPH.Count; i++)
            {
                Medicine m = medListPH.ElementAt(i);
                if (m.Medicine_Name.Equals(name))
                {
                    return medListPH.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a medicine registered to that description");
            return null;
        }

        public List<Medicine> GetAllMedicinesPhyschel()
        {
            return medListPH;
        }

        public void AddMedicineLaBomba(Medicine med)
        {
            medListLB.Add(med);
        }

        public String RemoveMedicineLaBomba(string name)
        {
            for (int i = 0; i < medListLB.Count; i++)
            {
                Medicine m = medListLB.ElementAt(i);
                if (m.Medicine_Name.Equals(name))
                {
                    medListLB.RemoveAt(i);
                    return "Medicine successfully deleted";
                }
            }
            return "There's no medicine registered to that name";

        }

        public Medicine GetMedicineLaBomba(string name)
        {
            for (int i = 0; i < medListPH.Count; i++)
            {
                Medicine m = medListLB.ElementAt(i);
                if (m.Medicine_Name.Equals(name))
                {
                    return medListLB.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a medicine registered to that description");
            return null;
        }

        public List<Medicine> GetAllMedicinesLaBomba()
        {
            return medListLB;
        }

    }
}