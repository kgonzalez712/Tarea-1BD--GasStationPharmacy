using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GasStationPharmacyRestServer.Models;

namespace GasStationPharmacyRestServer.Models
{
    public class DoctorRegister
    {
        List<Doctor> docListPhischel;
        List<Doctor> docListLaBomba;

        static DoctorRegister doc_reg = null;

        private DoctorRegister()
        {
            docListPhischel = new List<Doctor>();
            docListLaBomba = new List<Doctor>();
            Doctor a = new Doctor();
            Doctor b = new Doctor();

            a.Doctor_DID = 3245875245;
            a.Doctor_DID = 345;
            a.Doctor_First_Name = "Dr. Mario";
            a.Doctor_Last_Name = "lele";
            a.Doctor_Birthday = DateTime.Parse("07/23/1890");
            a.Doctor_Address = "huehue";

            b.Doctor_ID = 34575788;
            b.Doctor_DID = 45;
            b.Doctor_First_Name = "lolo";
            b.Doctor_Last_Name = "lulu";
            b.Doctor_Birthday = DateTime.Parse("07/11/1890");
            b.Doctor_Address = "huue";

            docListPhischel.Add(a);
            docListPhischel.Add(b);
            docListLaBomba.Add(b);
            docListLaBomba.Add(a);
        }

        public static DoctorRegister GetInstance()
        {
            if (doc_reg == null)
            {
                doc_reg = new DoctorRegister();
                return doc_reg;
            }
            else
            {
                return doc_reg;
            }
        }

//----------------------------------------- Pischell -----------------------------------------------

        public void AddPhischelDoctor(Doctor doctor)
        {
            docListPhischel.Add(doctor);
        }

        public String RemovePhischelDoctor(int doc_id)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doc_id))
                {
                    docListPhischel.RemoveAt(i);
                    return "Doctor successfully deleted";
                }
            }
            return "There isn't a doctor registered to that ID number";
        }

        public Doctor GetPhischelDoctor(int doc_id)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doc_id))
                {

                    return docListPhischel.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a client registered to that ID number");
            return null;
        }

        public List<Doctor> GetAllPhischelDoctors()
        {
            return docListPhischel;
        }

        public void UpdatePhischelDoctorFirstName(Doctor doctor, string name)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_First_Name = name;
                }
            }
        }

        public void UpdatePhischelDoctorLastName(Doctor doctor, string name)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Last_Name = name;
                }
            }
        }

        public void UpdatePhischelDoctorAddress(Doctor doctor, string address)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Address = address;
                }
            }
        }

        public void UpdatePhischelDoctorBirthDate(Doctor doctor, DateTime bd)
        {
            for (int i = 0; i < docListPhischel.Count; i++)
            {
                Doctor doc = docListPhischel.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Birthday = bd;
                }
            }
        }

//--------------------------------------------- La Bomba ------------------------------------------


        public void AddLaBombaDoctor(Doctor doctor)
        {
            docListLaBomba.Add(doctor);
        }

        public String RemoveLaBombaDoctor(int doc_id)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doc_id))
                {
                    docListLaBomba.RemoveAt(i);
                    return "Doctor successfully deleted";
                }
            }
            return "There isn't a doctor registered to that ID number";
        }

        public Doctor GetLaBombaDoctor(int doc_id)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doc_id))
                {

                    return docListLaBomba.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a client registered to that ID number");
            return null;
        }

        public List<Doctor> GetAllLaBombaDoctors()
        {
            return docListLaBomba;
        }

        public void UpdateLaBombaDoctorFirstName(Doctor doctor, string name)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_First_Name = name;
                }
            }
        }

        public void UpdateLaBombaDoctorLastName(Doctor doctor, string name)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Last_Name = name;
                }
            }
        }

        public void UpdateLaBombaDoctorAddress(Doctor doctor, string address)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Address = address;
                }
            }
        }

        public void UpdateLaBombaDoctorBirthDate(Doctor doctor, DateTime bd)
        {
            for (int i = 0; i < docListLaBomba.Count; i++)
            {
                Doctor doc = docListLaBomba.ElementAt(i);
                if (doc.Doctor_DID.Equals(doctor.Doctor_DID))
                {
                    doc.Doctor_Birthday = bd;
                }
            }
        }

    }
}
