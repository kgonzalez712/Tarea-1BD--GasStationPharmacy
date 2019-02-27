using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyRestServer.Models
{
    public class ClientRegister
    {
        List<Client> clientListLaBomba;
        List<Client> clientListPhischel;
        public int i = 0;
        static ClientRegister client_reg = null;

        private ClientRegister()
        {
            clientListLaBomba = new List<Client>();
            clientListPhischel = new List<Client>();
            Client a = new Client();
            Client b = new Client();
            a.Client_ID = 345;
            a.Client_First_Name = "lala";
            a.Client_Last_Name = "lele";
            a.Client_Birthday = DateTime.Parse("07/23/1890");
            a.Client_Address = "huehue";
            a.Client_Additional_Information = "Tuberculosis";
            a.Account_Password = "123344";
            a.Account_Email = "prueba@email.com";


            b.Client_ID = 3444;
            b.Client_First_Name = "lolo";
            b.Client_Last_Name = "lulu";
            b.Client_Birthday = DateTime.Parse("07/11/1890");
            b.Client_Address = "huue";
            b.Client_Additional_Information = "Tuberculosis b";
            b.Account_Password = "123344";
            b.Account_Email = "prueba@email.com";

            clientListLaBomba.Add(a);
            clientListLaBomba.Add(b);
            clientListPhischel.Add(b);
            clientListPhischel.Add(a);
        }

        public static ClientRegister GetInstance()
        {
            if (client_reg == null)
            {
                client_reg = new ClientRegister();
                return client_reg;
            }
            else
            {
                return client_reg;
            }
        }


        public void AddLaBombaClient(Client client)
        {
            clientListLaBomba.Add(client);
        }

        public String RemoveLaBombaClient(int id)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(id))
                {
                    clientListLaBomba.RemoveAt(i);
                    return "Client successfully deleted";
                }
            }
            return "There isn't a client registered to that ID number";
        }

        public Client GetLaBombaClient(int id)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(id))
                {

                    return clientListLaBomba.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a client registered to that ID number");
            return null;
        }

        public List<Client> getAllLaBombaClients()
        {
            return clientListLaBomba;
        }

        public void UpdateLaBombaClientFirstName(Client client, string name)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_First_Name = name; ;
                }
            }
        }

        public void UpdateLaBombaClientLastName(Client client, string name)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Last_Name = name; ;
                }
            }

        }

        public void UpdateLaBombaClientAddress(Client client, string address)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Address = address;
                }
            }
        }

        public void UpdateLaBombaClientInfo(Client client, string info)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Additional_Information = info;
                }
            }
        }

        public void UpdateLaBombaClientEmail(Client client, string email)
        {
            for (int i = 0; i < clientListLaBomba.Count; i++)
            {
                Client clnt = clientListLaBomba.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Account_Email = email;
                }
            }
        }

        public void UpdateLaBomaClientPassword(Client client, string password)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Account_Password = password;
                }
            }
        }


        public void AddPhischelClient(Client client)
        {
            clientListPhischel.Add(client);
        }

        public String RemovePhischelCLient(int id)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(id))
                {
                    clientListPhischel.RemoveAt(i);
                    return "Client successfully deleted";
                }
            }
            return "There isn't a client registered to that ID number";
        }

        public Client GetPhischelClient(int id)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(id))
                {

                    return clientListPhischel.ElementAt(i);
                }
            }
            Console.WriteLine("There isn't a client registered to that ID number");
            return null;
        }

        public List<Client> getAllPhischelClients()
        {
            return clientListPhischel;
        }

        public void UpdatePhischelClientFirstName(Client client, string name)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_First_Name = name; ;
                }
            }
        }

        public void UpdatePhischelClientLastName(Client client, string name)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Last_Name = name; ;
                }
            }

        }

        public void UpdatePhischelClientAddress(Client client, string address)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Address = address ;
                }
            }
        }

        public void UpdatePhischelClientInfo(Client client, string info)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Client_Additional_Information = info;
                }
            }
        }

        public void UpdatePhischelClientEmail(Client client, string email)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Account_Email= email;
                }
            }
        }

        public void UpdatePhischelClientPassword(Client client, string password)
        {
            for (int i = 0; i < clientListPhischel.Count; i++)
            {
                Client clnt = clientListPhischel.ElementAt(i);
                if (clnt.Client_ID.Equals(client.Client_ID))
                {
                    clnt.Account_Password = password;
                }
            }
        }

    }


}