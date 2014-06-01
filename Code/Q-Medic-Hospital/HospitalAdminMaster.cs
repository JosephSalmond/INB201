using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Medic_Hospital
{
    public partial class HospitalAdminMaster : Form
    {
        public enum forms {HospitalAdminMain, PatientProfile, StaffProfile};
        Form HospitalAdminMain, PatientProfile, StaffProfile;
        public int PaitentID;
        public HospitalAdminMaster()
        {
            
            InitializeComponent();
            HospitalAdminMain = new Q_Medic_Hospital.Hospital_Admin();
            PatientProfile = new Q_Medic_Hospital.PaitentProfile();
            StaffProfile = new Q_Medic_Hospital.Staff_details();

            HospitalAdminMain.WindowState = FormWindowState.Maximized;
            PatientProfile.WindowState = FormWindowState.Maximized;
            StaffProfile.WindowState = FormWindowState.Maximized;

            HospitalAdminMain.MdiParent = this;
            PatientProfile.MdiParent = this;
            StaffProfile.MdiParent = this;

            HospitalAdminMain.Show();
            }


        public void ChangeForm() {
        }

        private void NurseMaster_Load(object sender, EventArgs e) {

        }

        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.HospitalAdminMain) {
                PatientProfile.Hide();
                StaffProfile.Hide();
                HospitalAdminMain.Show();
            } else if (nextform == forms.PatientProfile) {
                HospitalAdminMain.Hide();
                StaffProfile.Hide();
                PatientProfile.Show();
            } else if (nextform == forms.StaffProfile) {
                HospitalAdminMain.Hide();
                PatientProfile.Hide();
                StaffProfile.Show();
            }
        }


    }
}
