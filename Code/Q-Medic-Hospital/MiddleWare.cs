using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Q_Medic_Hospital {
    public enum userType { LUSER = 0, SYSADMIN, DOCTOR, NURSE, RECEPTIONIST, HOSPITALADMIN, MEDTECH }

    public class MiddleWare {
        public string[] stringUser = { "Luser", "SysAdmin", "Doctor", "Nurse", "Receptionist", "HospitalAdmin", "MedTech" };
        enum querieType { LOGIN, DERP, AUTH };

        private bool authenticated = false;


        SqlConnection dbConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=hospital; connection timeout=60;");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        static void Main() {
            Form login = new Q_Medic_Hospital.Login();
            login.Show();
            Application.Run();

        }


        public MiddleWare() {
        }

        /* 
         * Creates the SYSTEM ADMIN 
         */
        public bool createAdmin(string adminUsername, string adminPassword, string adminEmail) {
            OpenConnection();
            Console.WriteLine("Debugging createAdmin(): ");
            sqlCmd.CommandText = string.Format("INSERT INTO Auth VALUES (" + adminUsername + ", " + adminPassword + ", " + adminEmail + ")");
            sqlCmd.Connection = dbConnection;
            return sqlCmd.ExecuteNonQuery() > 0;
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





        public bool Register(userType user, string username, string password, string firstName, string lastName, string Email) {

            bool succsess = false;
            firstName = "First";
            lastName = "Last";

            // if username not exist in DB
            if (true) {

                // find valid id

                // create user/password/usertype in table.auth

                if (user == userType.DOCTOR) {
                    // Doctor registry
                    SqlCommand registerDoc = new SqlCommand("INSERT INTO Doctors (firstName, lastName, email) " +
                                                 "Values ('firstName', 'lastName', 'email')", dbConnection);
                } else if (user == userType.NURSE) {
                    // Nurse registry
                    SqlCommand registerNuse = new SqlCommand("INSERT INTO Nurses (firstName, lastName, email) " +
                                                 "Values ('firstName', 'lastName', 'email')", dbConnection);
                } else if (user == userType.RECEPTIONIST) {
                    // Receptionist registry
                    SqlCommand registerRecept = new SqlCommand("INSERT INTO Receptionist (doctorId, firstName, lastName, email) " +
                        "Values ('firstName', 'lastName', 'email')", dbConnection);
                }
                return succsess;
            } else {
                // user already exists error
                return succsess;
            }
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
        private string soHigh(string userName, string password) {
            string hashedPassword;

            var salt = System.Text.Encoding.UTF8.GetBytes(userName);
            var pass = System.Text.Encoding.UTF8.GetBytes(password);

            var hmacSHA256 = new HMACSHA256(salt);
            var saltedPassword = hmacSHA256.ComputeHash(pass);

            hashedPassword = Convert.ToBase64String(saltedPassword);
            // hashing method


            return hashedPassword;
        }
    }
}
