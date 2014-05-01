using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
public enum userType {LUSER = 0, ADMIN, DOCTOR, NURSE, RECEPTIONIST }

   public class MiddleWare {
        public string[] stringUser = {"Luser", "Admin", "Doctor", "Nurse", "Receptionist"};
        enum querieType { LOGIN, DERP, AUTH };
        
        private bool authenticated = false;
        private userType thisUser = userType.LUSER;
        private userType user = userType.LUSER;

        SqlConnection dbConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=hospital; connection timeout=60;");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        public MiddleWare() {
        }

        public bool AuthTest(string username, string password, ref userType theUser) {
            bool autorised = false;
            OpenConnection();
            Console.WriteLine("Debugging:");
            sqlCmd.CommandText = string.Format("select * from Auth WHERE UserName='{0}' AND Password='{1}';", username, password);
            sqlCmd.Connection = dbConnection;
            reader = sqlCmd.ExecuteReader();
              if (reader.HasRows) {
                reader.Read();
                if ((username == reader.GetString(0)) && (password == reader.GetString(1))) {
                    theUser = (userType)Array.IndexOf(stringUser, reader.GetString(2));
                    autorised = true;
                }
            }
              Console.WriteLine("{0} {1}", username, password);
            
            if (reader.HasRows) {
                while (reader.Read()) {
                    if (reader.GetString(0) == username) {
                        Console.WriteLine("Username Correct");
                    } else if (reader.GetString(0) != username) {
                        Console.WriteLine("Username Incorrect");
                    }
                    if (reader.GetString(1) == password) {
                        Console.WriteLine("Password Correct");
                    } else if (reader.GetString(1) != password) {
                        Console.WriteLine("Password Incorrect");
                    }
                }
            }
            
            if (reader.HasRows) {
                while (reader.Read()) {
                    Console.WriteLine("{0} {1} {2}", reader.GetString(0),
                    reader.GetString(1), reader.GetString(2));
                }
            } else if (!reader.HasRows) {
                Console.WriteLine("no Output");
            }
            CloseConnection();

            return autorised;

        }






        private void Register(userType user) {

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
            SqlCommand registerNuse = new SqlCommand("INSERT INTO Nurses (firstName, lastName, email) " +
                                         "Values ('firstName', 'lastName', 'email')", dbConnection);
            // Receptionist registry
            SqlCommand registerRecept = new SqlCommand("INSERT INTO Receptionist (doctorId, firstName, lastName, email) " +
                "Values ('firstName', 'lastName', 'email')", dbConnection);
        }
        // Queries the database
      /*  public string[] DatabaseQuery(string querie, querieType type) {
            string username = "Admin";
            string password = "password";
            string authenticationQuerie = "select * from Auth WHERE UserName='8823928' AND Password='thepassword';";

            string[] dummy = DatabaseGet(querie);


            // authenticate user
            if (type == querieType.AUTH) {
                this.authenticated = DatabaseAuth(dummy, username, password);
            } else if (this.authenticated == true) {
            } else {
                string[] failure = { "-1", "Access Denied" };
                return failure;
            }

            // other querie's




            return dummy;
        }*/


        // authenticates against the database
        private bool DatabaseAuth(string[] querieResults, string username, string password) {

            if ((username == querieResults[0]) && (password == querieResults[1])) {
                return true;
            } else {

                return false;
            }
        }

        // queries database and returns results
        private string[] DatabaseGet(string querie) {
            OpenConnection();
            sqlCmd.CommandText = querie;
            reader = sqlCmd.ExecuteReader();
            string[] dummyCheck = null;
            int i = 0;

            while (reader.Read()) {
                dummyCheck[i] = reader[0].ToString();
                i++;
            }

            CloseConnection();
            return dummyCheck;
        }

        //opens connection
        private void OpenConnection() {
            try {
                dbConnection.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //closes connection
        private void CloseConnection() {
            dbConnection.Close();
        }

        // hashes password
        private string soHigh(string password) {
            string hashedPassword = null;
            // hashing method
            hashedPassword = password;

            return hashedPassword;
        }
    }
}
