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
        public static MiddleWare middle;
        public string[] stringUser = { "Luser", "SysAdmin", "Doctor", "Nurse", "Receptionist", "HospitalAdmin", "MedTech" };
        enum querieType { LOGIN, DERP, AUTH };
        public int userid;
        bool debugging = false;



        //public SqlConnection dbConnection = new SqlConnection("server =localhost; Trusted_Connection=yes; database=INB201; connection timeout=60;"); // SQL server
        public SqlConnection dbConnection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\SA878\\Documents\\INB201\\Code\\Q-Medic-Hospital\\INB201.mdf;Integrated Security=True");  // MDF file
        //public SqlConnection dbConnection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\JEGO\\Documents\\QUT\\github\\Code\\Q-Medic-Hospital\\INB201.mdf;Integrated Security=True");  // MDF file
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;

        static void Main() {
            middle = new MiddleWare(); 
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

            sqlCmd.CommandText = string.Format("select StaffName, Password, StaffTypeID, StaffID from Staff WHERE StaffName='{0}' AND Password='{1}';", username, password);
            sqlCmd.Connection = dbConnection;
            reader = sqlCmd.ExecuteReader();
            if (reader.HasRows) {
                reader.Read();
                if ((username == reader.GetString(0)) && (password == reader.GetString(1))) {
                    userid = reader.GetInt32(3);
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
        public void OpenConnection() {
            try {
                dbConnection.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //closes connection
        public void CloseConnection() {
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
        // populates database
        public void popualteDatabase() {
            OpenConnection();
            SqlCommand PurgeTableStaff = new SqlCommand("DELETE from Staff",dbConnection);
            SqlCommand PurgeTablePatients = new SqlCommand("DELETE from Patients", dbConnection);
            SqlCommand PurgeTableTreatment = new SqlCommand("DELETE from Treatment", dbConnection);
            SqlCommand PurgeTableFees = new SqlCommand("DELETE from Fees", dbConnection);
            PurgeTableTreatment.ExecuteNonQuery();
            PurgeTableFees.ExecuteNonQuery();
            PurgeTablePatients.ExecuteNonQuery();
            PurgeTableStaff.ExecuteNonQuery();
            SqlCommand PurgeTableStaff2 = new SqlCommand("DBCC CHECKIDENT('Staff', RESEED, 0)", dbConnection);
            SqlCommand PurgeTablePatients2 = new SqlCommand("DBCC CHECKIDENT('Patients', RESEED, 0)", dbConnection);
            SqlCommand PurgeTableTreatment2 = new SqlCommand("DBCC CHECKIDENT('Treatment', RESEED, 0)", dbConnection);
            PurgeTableTreatment2.ExecuteNonQuery();
            PurgeTablePatients2.ExecuteNonQuery();
            PurgeTableStaff2.ExecuteNonQuery();

            CloseConnection();
            createStaff();
            createPatients();
            CreateTreatments();
        }


        // adds default staff to db
        private void createStaff() {
            for (int i = 0; i < stringUser.Length; i++) {
                Register((userType)i, stringUser[i], "password", stringUser[i], stringUser[i], stringUser[i] + "@hospital.qld.edu.au");
            }
        }
        // adds patients to db
        private void createPatients() {
            Random rand = new Random();
            IEnumerable<string> FirtName = File.ReadLines("FirstName.txt");
            IEnumerable<string> LastName = File.ReadLines("LastName.txt");

            OpenConnection();
            for (int i = 0; i < 200; i++) {
                SqlCommand register = null;
                var FirtNameToRead = rand.Next(1, FirtName.Count());
                var LastNameToRead = rand.Next(1, LastName.Count());
                String FirtNameline = FirtName.Skip(FirtNameToRead - 1).First();
                String LastNameline = LastName.Skip(LastNameToRead - 1).First();
                String email = FirtNameline + LastNameline + "@herp.com";
                Random random = new Random();
                int StreetNumber = random.Next(0, 1000);
                int Postcode = random.Next(0, 10000);
                int PhoneNumber = random.Next(0, 10000000);
                int MobileNumber = random.Next(0, 10000000);
                register = new SqlCommand(string.Format("INSERT Patients (LastName, FirstName, Email, StreetNo, StreetAddress, Suburb, PostCode, PhoneNumber, MobileNumber)" +
                    "Values('{0}','{1}','{2}','{3}','Saddress', 'suburb', '{4}', '{5}','{6}')", FirtNameline, LastNameline, email, StreetNumber, Postcode, PhoneNumber, MobileNumber), dbConnection);

                register.ExecuteNonQuery();
            }
            CloseConnection();

        }

        //adds Treatments automaticly to db
        private void CreateTreatments() {
            SqlCommand treatMe = null;
            SqlCommand billMe = null;
            Random rand = new Random();

            OpenConnection();
            for (int i = 0; i < 2000; i++) {
                int der = rand.Next(2, 7);
                int pid = rand.Next(1, 199);
                float cost = (float)rand.Next(rand.Next(10, 1000),rand.Next(1000, 100000));
                String dateString = DateTime.Now.ToString("dd/mm/yyyy");
                String timeString = DateTime.Now.ToString("HH:mm:ss");

                treatMe = new SqlCommand(string.Format("INSERT Treatment (PatientID, StaffID, FeeID, DoctorsNotes, NurseObservations, TreatmentDate, TreatmentTime, Admitted)" +
    "VALUES('{0}','{1}','{3}','{4}','{5}','{6}','{7}','{8}')", pid, der, 0, i, "Dobs", "Nobs", dateString, timeString, true), dbConnection);
                billMe = new SqlCommand(string.Format("INSERT Fees(FeeID, GrossCost, FeePaidDate,Comments, TotalCost)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", i, cost, null, "Unpaid", cost), dbConnection);
                billMe.ExecuteNonQuery();
                treatMe.ExecuteNonQuery();


            }
            CloseConnection();
        }
    }
}
