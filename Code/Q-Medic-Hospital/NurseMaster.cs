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
    public partial class NurseMaster : Form
    {
        public enum forms {NurseMain, Observation, BedAllocation, PatientActivity, StaffProfile};
        Form SubForm, ObservationForm, BedForm, ActivityForm, StaffProfile;

        public NurseMaster()
        {
            
            InitializeComponent();
            SubForm = new Q_Medic_Hospital.NurseMainPage();
            ObservationForm = new Q_Medic_Hospital.Observations();
            BedForm = new Q_Medic_Hospital.PatientRooms();
            ActivityForm = new Q_Medic_Hospital.Patient_Activities();
            StaffProfile = new Q_Medic_Hospital.Staff_details();

            SubForm.WindowState = FormWindowState.Maximized;
            ObservationForm.WindowState = FormWindowState.Maximized;
            BedForm.WindowState = FormWindowState.Maximized;
            ActivityForm.WindowState = FormWindowState.Maximized;
            StaffProfile.WindowState = FormWindowState.Maximized;

            SubForm.MdiParent = this;
            ObservationForm.MdiParent = this;
            BedForm.MdiParent = this;
            ActivityForm.MdiParent = this;
            StaffProfile.MdiParent = this;

            SubForm.Show();
            }


        public void ChangeForm() {
        }

        private void NurseMaster_Load(object sender, EventArgs e) {

        }

        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.NurseMain) {
                ObservationForm.Hide();
                BedForm.Hide();
                ActivityForm.Hide();
                StaffProfile.Hide();
                SubForm.Show();
            } else if (nextform == forms.Observation) {
                SubForm.Hide();
                BedForm.Hide();
                ActivityForm.Hide();
                StaffProfile.Hide();
                ObservationForm.Show();
            } else if (nextform == forms.BedAllocation){
                SubForm.Hide();
                ObservationForm.Hide();
                ActivityForm.Hide();
                StaffProfile.Hide();
                BedForm.Show();
            }else if(nextform == forms.PatientActivity){
                SubForm.Hide();
                ObservationForm.Hide();
                BedForm.Hide();
                StaffProfile.Hide();
                ActivityForm.Show();
            } else if (nextform == forms.StaffProfile) {
                SubForm.Hide();
                ObservationForm.Hide();
                BedForm.Hide();
                ActivityForm.Hide();
                StaffProfile.Show();
            }
        }


    }
}
