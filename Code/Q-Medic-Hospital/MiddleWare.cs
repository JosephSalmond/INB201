using System;
using System.IO;
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
        bool debugging = false;



        SqlConnection dbConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=INB201; connection timeout=60;");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        static void Main() {
            Form login = new Q_Medic_Hospital.Login();
            //Form login = new Q_Medic_Hospital.Registry();
            //Form login = new Q_Medic_Hospital.NurseMaster();
            //Form login = new Q_Medic_Hospital.Doctor();
            login.Show();
            Application.Run();


        }


        public MiddleWare() {
        }


        public bool AuthTest(string username, string password, ref userType theUser) {
            bool autorised = false;
            OpenConnection();
            Console.WriteLine("Debugging:");
            soHigh(username, ref password);

            sqlCmd.CommandText = string.Format("select StaffName, Password, StaffTypeID from Staff WHERE StaffName='{0}' AND Password='{1}';", username, password);
            sqlCmd.Connection = dbConnection;
            reader = sqlCmd.ExecuteReader();
            if (reader.HasRows) {
                reader.Read();
                if ((username == reader.GetString(0)) && (password == reader.GetString(1))) {
                    theUser = (userType)reader.GetInt32(2);
                    autorised = true;

                }
            }
            if(debugging){
            AuthDebugging(username, password);
            }

            CloseConnection();

            return autorised;
        }

        private void AuthDebugging(string username, string password) {
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
        }
        /*  // adds automaticly to db
        public void createPatients() {
            Random rand = new Random();
            IEnumerable<string> FirtName = File.ReadLines("FirstName.txt");
            IEnumerable<string> LastName = File.ReadLines("LastName.txt");
            
            OpenConnection();
            for (int i = 0; i < 200; i++){
            SqlCommand register = null;
            var FirtNameToRead = rand.Next(1, FirtName.Count());
            var LastNameToRead = rand.Next(1, LastName.Count());
            String FirtNameline = FirtName.Skip(FirtNameToRead - 1).First();
            String LastNameline = LastName.Skip(LastNameToRead - 1).First();
            String email = FirtNameline + LastNameline + "@herp.com";

            register = new SqlCommand(string.Format("INSERT Patients (LastName, FirstName, Email)" +
                "Values('{0}','{1}','{2}')", FirtNameline, LastNameline, email), dbConnection);

            register.ExecuteNonQuery();
        }
            CloseConnection();

        }

         //adds stuff automaticly to db assumes 5 staff added
        public void CreateTreatments (){
            SqlCommand treatMe = null;
            SqlCommand billMe = null;
            Random rand = new Random();

            OpenConnection();
            for (int i = 0; i < 200; i++) {
                int der = rand.Next(2,4);
                int pid = rand.Next(1, 199);
                int room = rand.Next(1, 200);
                int bed = rand.Next(1, 4);
                float cost = (float)rand.Next(10,10000);
                String dateString = DateTime.Now.ToString("dd/mm/yyyy");
                String timeString = DateTime.Now.ToString("HH:mm:ss");

                treatMe = new SqlCommand(string.Format("INSERT Treatment (PatientID, StaffID, FeeID, RoomNo, DoctorsNotes, NurseObservations, TreatmentDate, TreatmentTime, Admitted, BedNo)" +
    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", pid, der, i, room, "Dobs", "Nobs", dateString, timeString, true, bed), dbConnection);
                billMe = new SqlCommand(string.Format("INSERT Fees(FeeID, FeeCost, FeePaidDate,Comments)"+
                    "VALUES('{0}','{1}','{2}','{3}')", i, cost, null, "Unpaid"), dbConnection);
                billMe.ExecuteNonQuery();
                treatMe.ExecuteNonQuery();


            }
            CloseConnection();
    }
        */


        public bool Register(userType user, string username, string password, string firstName, string lastName, string email) {

            bool succsess = false;
            bool usernameExists = false;
            firstName = "First";
            lastName = "Last";
            SqlCommand register = null;
            OpenConnection();

            soHigh(username, ref password);
            sqlCmd.CommandText = string.Format("select StaffName from Staff WHERE StaffName='{0}';", username);
            sqlCmd.Connection = dbConnection;
            reader = sqlCmd.ExecuteReader();

            if (reader.HasRows) {
                reader.Read();

                if (username == reader.GetString(0)) {
                    usernameExists = true;
                }
            }
            CloseConnection();
            if (!usernameExists && (int)user != -1) {
  
                register = new SqlCommand(string.Format("INSERT Staff (StaffName, Password, StaffTypeID, FirstName, LastName, Email)" +
                "Values('{0}','{1}','{2}','{3}','{4}','{5}')", username, password, (int)user, firstName, lastName, email), dbConnection);

                OpenConnection();
                register.ExecuteNonQuery();
                CloseConnection();
            } else {
                // user already exists error
                Console.WriteLine("user already exists");
            }
            




            CloseConnection();
            return succsess;
        }



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
        private void soHigh(string userName, ref string password) {

            var salt = System.Text.Encoding.UTF8.GetBytes(userName);
            var pepper = System.Text.Encoding.UTF8.GetBytes(password);
                        var hmacSHA256 = new HMACSHA256(salt);
            var saltedPassword = hmacSHA256.ComputeHash(pepper);

            password = Convert.ToBase64String(saltedPassword);

        }
    }
}
