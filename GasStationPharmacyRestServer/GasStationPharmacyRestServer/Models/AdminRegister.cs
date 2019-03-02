using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models
{
    public class AdminRegister
    {
        List<Administrator> adminListPH;
        List<Administrator> adminListLB;
        static AdminRegister admn_reg;

        private AdminRegister()
        {
            adminListPH = new List<Administrator>();
            adminListLB = new List<Administrator>();

            Administrator a = new Administrator();
            Administrator b = new Administrator();

            a.Admin_ID = 30419462;
            a.Admin_First_Name = "Kevin";
            a.Admin_Last_Name = "Gonzalez";
            a.Admin_Birthday = DateTime.Parse("07/12/1995");
            a.Admin_Phone_Number = 89974260;
            a.Admin_Address = "Cartago, la Pithaya";
            a.Account_Email = "dfghj@asd.com";
            a.Account_Password = "asdfg";

            b.Admin_ID = 30419462;
            b.Admin_First_Name = "Kevin";
            b.Admin_Last_Name = "Gonzalez";
            b.Admin_Birthday = DateTime.Parse("07/12/1995");
            b.Admin_Phone_Number = 89974260;
            b.Admin_Address = "Cartago, la Pithaya";
            b.Account_Email = "dfghj@asd.com";
            b.Account_Password = "asdfg";

            adminListLB.Add(b);
            adminListPH.Add(a);
        }

        public static AdminRegister GetInstance()
        {
            if (admn_reg == null)
            {
                admn_reg = new AdminRegister();
                return admn_reg;
            }
            else
            {
                return admn_reg;
            }
        }




        // ------------------------------------------ La Bomba ------------------------------------------------------------------------------


        public void AddLaBombaAdmin(Administrator admin)
        {
            adminListLB.Add(admin);
        }

        public String RemoveLaBombaAdmin(int id)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(id))
                {
                    adminListLB.RemoveAt(i);
                    return "Admin successfully deleted";
                }
            }
            return "There isn't a admin registered to that ID number";
        }

        public Administrator GetLaBombaAdmin(int id)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator adm = adminListLB.ElementAt(i);
                if (adm.Admin_ID.Equals(id))
                {

                    return adminListLB.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a admin registered to that ID number");
            return null;
        }

        public List<Administrator> getAllLaBombaAdmins()
        {
            return adminListLB;
        }

        public void UpdateLaBombaAdminFirstName(Administrator a, string name)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator adm = adminListLB.ElementAt(i);
                if (adm.Admin_ID.Equals(a.Admin_ID))
                {
                    adm.Admin_First_Name = name; ;
                }
            }
        }

        public void UpdateLaBombaAdminLastName(Administrator a, string name)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator adm = adminListLB.ElementAt(i);
                if (adm.Admin_ID.Equals(a.Admin_ID))
                {
                    adm.Admin_Last_Name = name; ;
                }
            }

        }

        public void UpdateLaBombaAdminAddress(Administrator a, string address)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Address = address;
                }
            }
        }

        public void UpdateLaBombaAdminEmail(Administrator a, string email)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Account_Email = email;
                }
            }
        }

        public void UpdateLaBombaAdminBirthDate(Administrator a, DateTime bd)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Birthday = bd;
                }
            }
        }

        public void UpdateLaBomaAdminPassword(Administrator a, string password)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Account_Password = password;
                }
            }
        }


        public void UpdateLaBombaAdminPhone(Administrator a, int num)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Phone_Number = num;
                }
            }
        }

        // ------------------------------------------ Pischell ----------------------------------------------------------------------


        public void AddPhyschelAdmin(Administrator admin)
        {
            adminListPH.Add(admin);
        }

        public String RemovePhyschelAdmin(int id)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator ad = adminListPH.ElementAt(i);
                if (ad.Admin_ID.Equals(id))
                {
                    adminListPH.RemoveAt(i);
                    return "Admin successfully deleted";
                }
            }
            return "There isn't a admin registered to that ID number";
        }

        public Administrator GetPhyschelAdmin(int id)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator adm = adminListPH.ElementAt(i);
                if (adm.Admin_ID.Equals(id))
                {

                    return adminListPH.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a admin registered to that ID number");
            return null;
        }

        public List<Administrator> getAllPhyschelAdmins()
        {
            return adminListPH;
        }

        public void UpdatePyschelAdminFirstName(Administrator a, string name)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator adm = adminListPH.ElementAt(i);
                if (adm.Admin_ID.Equals(a.Admin_ID))
                {
                    adm.Admin_First_Name = name; ;
                }
            }
        }

        public void UpdatePhyschelAdminLastName(Administrator a, string name)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator adm = adminListPH.ElementAt(i);
                if (adm.Admin_ID.Equals(a.Admin_ID))
                {
                    adm.Admin_Last_Name = name; ;
                }
            }

        }

        public void UpdatePhyschelAdminAddress(Administrator a, string address)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator ad = adminListPH.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Address = address;
                }
            }
        }

        public void UpdatePhyschelAdminEmail(Administrator a, string email)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator ad = adminListPH.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Account_Email = email;
                }
            }
        }

        public void UpdatePhyschelAdminBirthDate(Administrator a, DateTime bd)
        {
            for (int i = 0; i < adminListPH.Count; i++)
            {
                Administrator ad = adminListPH.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Birthday = bd;
                }
            }
        }

        public void UpdatePhyschelAdminPassword(Administrator a, string password)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Account_Password = password;
                }
            }
        }


        public void UpdatePhyschelAdminPhone(Administrator a, int num)
        {
            for (int i = 0; i < adminListLB.Count; i++)
            {
                Administrator ad = adminListLB.ElementAt(i);
                if (ad.Admin_ID.Equals(a.Admin_ID))
                {
                    ad.Admin_Phone_Number = num;
                }
            }
        }

    }
}