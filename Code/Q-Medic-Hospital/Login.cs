using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital {

    public partial class Login : Form {
        MiddleWare middle = new MiddleWare();

        public Login() {

            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            userType theUser = userType.LUSER;
            bool authorised = false;
            Form mainForm = null;

            authorised = middle.AuthTest(username, password, ref theUser);
            if (authorised) {
                
                if (theUser == userType.DOCTOR) {
                    mainForm = new Q_Medic_Hospital.Doctor();
                }else if (theUser == userType.NURSE){
                    textBox1.Text = "Welcom Nurse";
                } else if (theUser == userType.ADMIN) {
                    textBox1.Text = "Welcome Admin";
                } else if (theUser == userType.RECEPTIONIST) {
                    mainForm = new Q_Medic_Hospital.Receptionist();
                } else if (theUser == userType.LUSER) {
                    textBox1.Text = "What are you doing Dave";
                }
                if (mainForm != null) {
                    this.Hide();
                    mainForm.Show();
                }
            } else {
                textBox2.Text = "";
            }
        }
    }

/*
	// Form types
	private SystemAdminRegistryForm sysadminRegistry; // seperate for system admin = our tutor
	private StaffRegistryForm staffRegistry;
	private LoginForm login;
	private DocDiagnosisForm diagnosis;
	private NurseObservationForm observation;

	// User session - logged in.
	private boolean isAdmin; // seperate for sysadmin because he has registry confirmations pending.
	private boolean isLogged;

	public partial class Login : Form {
		public Login() {
			
			// For designer.
			private System.ComponentModel.IContainer parts = null;

		}
	}


		
	}*/
}
