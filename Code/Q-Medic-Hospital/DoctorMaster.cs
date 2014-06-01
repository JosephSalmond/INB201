using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
    public partial class DoctorMaster : Form {
        public enum forms { DoctorMain, StaffProfile, PaitentProfile};
        Form DoctorMain, StaffProfile, PaitentProfile;
        public int PaitentID;

        public DoctorMaster() {
            InitializeComponent();

            DoctorMain = new Q_Medic_Hospital.Doctor();
            StaffProfile = new Q_Medic_Hospital.Staff_details();
            PaitentProfile = new Q_Medic_Hospital.PaitentProfile();

            DoctorMain.WindowState = FormWindowState.Maximized;
            StaffProfile.WindowState = FormWindowState.Maximized;
            PaitentProfile.WindowState = FormWindowState.Maximized;

            DoctorMain.MdiParent = this;
            StaffProfile.MdiParent = this;
            PaitentProfile.MdiParent = this;

            DoctorMain.Show();
        }

        private void DoctorMaster_Load(object sender, EventArgs e) {

        }
        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.DoctorMain) {
                PaitentProfile.Hide();
                StaffProfile.Hide();
                DoctorMain.Show();
            } else if (nextform == forms.PaitentProfile) {
                DoctorMain.Hide();
                StaffProfile.Hide();
                PaitentProfile.Show();
            } else if (nextform == forms.StaffProfile) {
                DoctorMain.Hide();
                PaitentProfile.Hide();
                StaffProfile.Show();
            } 
        }
    }
}
