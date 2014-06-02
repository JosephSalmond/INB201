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
        


        public Login() {

            InitializeComponent();
            this.AcceptButton = loginButton;
            MiddleWare.middle.popualteDatabase(); //resets and rebuilds staff patients treatment and fees
        }


        private void button1_Click(object sender, EventArgs e) {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            userType theUser = userType.LUSER;
            bool authorised = false;
            Form mainForm = null;

            authorised = MiddleWare.middle.AuthTest(username, password, ref theUser);
            if (authorised) {
                if (theUser == userType.DOCTOR) {
                    mainForm = new Q_Medic_Hospital.DoctorMaster();
                }else if (theUser == userType.NURSE){
                    mainForm = new Q_Medic_Hospital.NurseMaster();
                } else if (theUser == userType.SYSADMIN) {
                    mainForm = new Q_Medic_Hospital.SysAdminMaster();
                } else if (theUser == userType.RECEPTIONIST) {
                    mainForm = new Q_Medic_Hospital.ReceptionistMaster();
                } else if (theUser == userType.HOSPITALADMIN){
                    mainForm = new Q_Medic_Hospital.HospitalAdminMaster();
                } else if (theUser == userType.MEDTECH) {
                    mainForm = new Q_Medic_Hospital.MedTechMaster();
                }else if (theUser == userType.LUSER) {
                    textBox1.Text = "Insufficiant Privilages";
                }
                if (mainForm != null) {
                    this.Hide();
                    mainForm.Show();
                    this.Close();
                }
            } else {
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Please Contact System Administrator", "Warning", MessageBoxButtons.OK);
        }

        private void Login_Load(object sender, EventArgs e) {

        }

    }

}
