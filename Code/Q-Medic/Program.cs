using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q_Medic {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        enum querieType { LOGIN, DERP, AUTH };
        enum userType {Luser, DOCTOR, NURSE}
        private bool authenticated = false;
        private userType thisUser = userType.Luser;
        SqlConnection databaseConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=; connection timeout=30;");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        static void Main() {
           
            
        }

        // queries the database
        private string[] DatabaseQuerie(string querie, querieType type) {
            string username = "Admin";
            string password = "password";
            sqlCmd.CommandText = "SELECT * FROM Customers";

            string[] dummy = DatabaseGet(sqlCmd.CommandText);


            // authenticate user
            if (type == querieType.AUTH) {
                authenticated = DatabaseAuth(querie, username, password);
            } else if (authenticated == true) {
            } else {
                // not authenticates
            }

            // other querie's

            


            return dummy;
            }

       
        // authenticates against the database
        private bool DatabaseAuth(string querie, string username, string password) {
            string[] dummyCheck = DatabaseGet(querie);

            if ((username == dummyCheck[0]) && (password == dummyCheck[1])) {
                return true;
            } else {

                return false;
            }
        }

        // queries database and returns results
        private string[] DatabaseGet(string querie) {
            OpenConnection();

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
        private void OpenConnection() {
            try {
                databaseConnection.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //closes connection
        private void CloseConnection() {
            databaseConnection.Close();
        }

        // hashes password
        private string soHigh(string password){
            string hashedPassword = null;
            // hashing method
            hashedPassword = password;

            return hashedPassword;
        }

    }
}
