using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace casaApplication
{
    class myADO
    {
        // SqlConnection howa eli nconnection bih lél base fih:
        //Methods
        //.Open()  
        //.Close()   
        //.State.ToString() => narfou bih state open wala closed

        //Attributes
        //.ConnectionString = Attribute tékhou linformation té3 él base w server mté3i
        public static SqlConnection myConnection = new SqlConnection();



        // SqlCommand The SqlCommand class is used to execute the SQL statements (SELECT, UPDATE, DELETE)
        //Attributes
        // .Connection = tékhou objet mté3 SqlConnection  éli howa myConnection (myConnection éna samitou)
        // .CommandText = tékhou él sql statement éli matlouba

        //Methods
        // .ExecuteReader() => execute the query (select) 
        // .ExecuteNonQuery() => execute the CUD (CREATE, UPDATE, Delete) 
        public SqlCommand myCommande = new SqlCommand();



        public SqlDataReader myDataReader;



        public bool connect()
        {
            //try because it can fail
            try
            {
                myConnection.ConnectionString = @"Data Source=LAPTOP-M79OPNIF\BELHASSENSQL;Initial Catalog=myProject;Integrated Security=True";
                myConnection.Open();
                MessageBox.Show(myConnection.State.ToString());
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connexion Impossible!\n" + e.Message);
                return false;
            }
        }
        public bool selectClient()
        {
            myCommande.Connection = myConnection;
            myCommande.CommandText = "select * from Client;";

            try
            {
                myDataReader = myCommande.ExecuteReader();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool addClient(String Code, String Nom, String Tel, String Email, String Web)
        {
            myCommande.Connection = myConnection;
            myCommande.CommandText = "INSERT INTO client values('" + Code + "', '" + Nom + "', '" + Tel + "', '" + Email + "', '" + Web + "');";

            try
            {
                myCommande.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool deleteClient(String code)
        {
            myCommande.Connection = myConnection;
            myCommande.CommandText = "DELETE FROM client where codecli = '" + code + "';";
            try
            {
                myCommande.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool findClient(String code)
        {
            myCommande.Connection = myConnection;
            myCommande.CommandText = "SELECT * from client where codecli = '" + code + "';";
            try
            {
                myDataReader = myCommande.ExecuteReader();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
