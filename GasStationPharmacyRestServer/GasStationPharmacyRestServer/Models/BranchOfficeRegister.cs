using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GasStationPharmacyRestServer.Models;

namespace GasStationPharmacyRestServer.Models
{
    public class BranchOfficeRegister
    {
        List<BranchOffice> BOListPH;
        List<BranchOffice> BOListLB;

        static BranchOfficeRegister bo_reg;

        private BranchOfficeRegister()
        {
            BOListPH = new List<BranchOffice>();
            BOListLB = new List<BranchOffice>();

            BranchOffice a = new BranchOffice();
            a.BranchOffice_Address = "Los Angeles, Cartago";
            a.BranchOffice_Admin_Name = "Carlos Araya";
            a.BranchOffice_Name = "La Bomba #1";

            BOListLB.Add(a);
        }

        public static BranchOfficeRegister GetInstance()
        {
            if (bo_reg == null)
            {
                bo_reg = new BranchOfficeRegister();
                return bo_reg;
            }
            else
            {
                return bo_reg;
            }
        }

//--------------------------------------- Phischell -------------------------------------------------------------------------

        public void AddBOPhyschel(BranchOffice bo)
        {
            BOListPH.Add(bo);
        }

        public String RemoveBOPhyschel(string name)
        {
            for (int i = 0; i < BOListPH.Count; i++)
            {
                BranchOffice bo = BOListPH.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(name))
                {
                    BOListPH.RemoveAt(i);
                    return "Branch Office successfully deleted";
                }
            }
            return "There's no Branch Office registered to that name";

        }


        public BranchOffice GetBOPhyschel(string name)
        {
            for (int i = 0; i < BOListPH.Count; i++)
            {
                BranchOffice bo = BOListPH.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(name))
                {
                    return BOListPH.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a BranchOffice registered to that description");
            return null;
        }

        public List<BranchOffice> GetAllBOPhyschel()
        {
            return BOListPH;
        }


        public void UpdateBOPHAdmin(BranchOffice branch, string name)
        {
            for(int i=0;i<BOListPH.Count();i++)
            {
                BranchOffice bo = BOListPH.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(branch.BranchOffice_Name))
                {
                    bo.BranchOffice_Admin_Name = name;
                }
            }
        }

        //-------------------------------------------- La Bomba --------------------------------------------------------

        public void AddBOLaBomba(BranchOffice bo)
        {
            BOListLB.Add(bo);
        }

        public String RemoveBOLaBomba(string name)
        {
            for (int i = 0; i < BOListLB.Count; i++)
            {
                BranchOffice bo = BOListLB.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(name))
                {
                    BOListLB.RemoveAt(i);
                    return "Branch Office successfully deleted";
                }
            }
            return "There's no Branch Office registered to that name";

        }


        public BranchOffice GetBOLaBomba(string name)
        {
            for (int i = 0; i < BOListLB.Count; i++)
            {
                BranchOffice bo = BOListLB.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(name))
                {
                    return BOListLB.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a BranchOffice registered to that description");
            return null;
        }

        public List<BranchOffice> GetAllBOLaBomba()
        {
            return BOListLB;
        }


        public void UpdateBOLBAdmin(BranchOffice branch, string name)
        {
            for (int i = 0; i < BOListLB.Count(); i++)
            {
                BranchOffice bo = BOListLB.ElementAt(i);
                if (bo.BranchOffice_Name.Equals(branch.BranchOffice_Name))
                {
                    bo.BranchOffice_Admin_Name = name;
                }
            }
        }
    }
}