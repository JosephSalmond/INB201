using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Q_Medic {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        enum querieType { LOGIN, DERP, AUTH };
        enum userType { DOCTOR, NURSE}
        private bool authenticated = false;

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        // queries the database
        private string[] DatabaseQuerie(string querie, querieType type) {
            string username = "Admin";
            string password = "password";
            // authenticate user
            if (type == querieType.AUTH) {
                authenticated = DatabaseAuth(querie, username, password);
            } else if (authenticated == true) {
            } else {
                // not authenticates
            }

            // other querie's

            string dummyString = "im a querie";
            string[] dummy = DatabaseGet(dummyString);


            return dummy;
            }

        


        // queries database and returns results
        private string[] DatabaseGet(string querie) {
            string[] dummyCheck = { querie };
            return dummyCheck;
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

        //opens connection
        private void OpenConnection() {

        }

        //closes connection
        private void CloseConnection() {

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
