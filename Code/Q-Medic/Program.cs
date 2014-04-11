using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q_Medic
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        enum querieType { LOGIN, DERP, AUTH };
        enum userType { ADMIN, DOCTOR, NURSE, RECEPTIONIST }
        private bool authenticated = false;
        private userType thisUser = userType.Luser;
        private userType user = userType.Luser;

        SqlConnection dbConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=hospital; connection timeout=30;");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        static void Main(){
            //

        }

        /* 
         * - Need forms for "Registry", then hospital admin should confirm them, before they are INSERTed in DB.
         * - Some example inserts.
         * - Better move these into a new class file.
         */
        String firstName, lastName, email; // Received from the forms.
        // Doctor registry
        SqlCommand registerDoc = new SqlCommand("INSERT INTO Doctors (firstName, lastName, email) " +
                                     "Values ('firstName', 'lastName', 'email')", dbConnection);
        // Nurse registry
        SqlCommand registerDoc = new SqlCommand("INSERT INTO Nurses (firstName, lastName, email) " +
                                     "Values ('firstName', 'lastName', 'email')", dbConnection);
        // Receptionist registry
        SqlCommand registerDoc = new SqlCommand("INSERT INTO Receptionist (doctorId, firstName, lastName, email) " +
            "Values ('firstName', 'lastName', 'email')", dbConnection);

        // Queries the database
        private string[] DatabaseQuery(string query, queryType type)
        {
            string username = "Admin";
            string password = "password";
            string authenticationQuerie = "SELECT user {0} user type";

            string[] dummy = DatabaseGet(querie);


            // authenticate user
            if (type == querieType.AUTH)
            {
                authenticated = DatabaseAuth(dummy, username, password);
            }
            else if (authenticated == true)
            {
            }
            else
            {
                string[] failure = { "-1", "Access Denied" };
                return failure;
            }

            // other querie's




            return dummy;
        }


        // authenticates against the database
        private bool DatabaseAuth(string[] querieResults, string username, string password)
        {

            if ((username == querieResults[0]) && (password == querieResults[1]))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        // queries database and returns results
        private string[] DatabaseGet(string querie)
        {
            OpenConnection();
            sqlCmd.CommandText = querie;
            reader = sqlCmd.ExecuteReader();
            string[] dummyCheck = null;
            int i = 0;

            while (reader.Read())
            {
                dummyCheck[i] = reader[0].ToString();
                i++;
            }

            CloseConnection();
            return dummyCheck;
        }

        //opens connection
        private void OpenConnection()
        {
            try
            {
                databaseConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //closes connection
        private void CloseConnection()
        {
            databaseConnection.Close();
        }

        // hashes password
        private string soHigh(string password)
        {
            string hashedPassword = null;
            // hashing method
            hashedPassword = password;

            return hashedPassword;
        }

    }
}
