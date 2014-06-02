using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
    public partial class ReceptionistMaster : Form {
        public enum forms { ReceptionistMain, PatientProfile, StaffProfile, PatientAppointments, PaitentRooms, FinancialFees };
        Form ReceptionistMain, PatientProfile, StaffProfile, PatientAppointments, PaitentRooms, FinancialFees;
        public int PaitentID;

        public ReceptionistMaster()
        {
            
            InitializeComponent();
            ReceptionistMain = new Q_Medic_Hospital.Receptionist();
            PatientProfile = new Q_Medic_Hospital.PaitentProfile();
            StaffProfile = new Q_Medic_Hospital.Staff_details();
            PatientAppointments = new Q_Medic_Hospital.Appointments();
            PaitentRooms = new Q_Medic_Hospital.PatientRooms();
            FinancialFees = new Q_Medic_Hospital.FinancialFees();


            ReceptionistMain.WindowState = FormWindowState.Maximized;
            PatientProfile.WindowState = FormWindowState.Maximized;
            StaffProfile.WindowState = FormWindowState.Maximized;
            PatientAppointments.WindowState = FormWindowState.Maximized;
            PaitentRooms.WindowState = FormWindowState.Maximized;
            FinancialFees.WindowState = FormWindowState.Maximized;

            ReceptionistMain.MdiParent = this;
            PatientProfile.MdiParent = this;
            StaffProfile.MdiParent = this;
            PatientAppointments.MdiParent = this;
            PaitentRooms.MdiParent = this;
            FinancialFees.MdiParent = this;


            ReceptionistMain.Show();
            }


        public void ChangeForm() {
        }

        private void NurseMaster_Load(object sender, EventArgs e) {

        }

        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.ReceptionistMain) {
                PatientProfile.Hide();
                StaffProfile.Hide();
                PatientAppointments.Hide();
                PaitentRooms.Hide();
                FinancialFees.Hide();
                ReceptionistMain.Show();

            } else if (nextform == forms.PatientProfile) {
                ReceptionistMain.Hide();
                StaffProfile.Hide();
                PatientAppointments.Hide();
                PaitentRooms.Hide();
                FinancialFees.Hide();
                PatientProfile.Show();

            } else if (nextform == forms.StaffProfile) {
                ReceptionistMain.Hide();
                PatientProfile.Hide();
                PatientAppointments.Hide();
                PaitentRooms.Hide();
                FinancialFees.Hide();
                StaffProfile.Show();

            } else if (nextform == forms.PatientAppointments) {
                ReceptionistMain.Hide();
                PatientProfile.Hide();
                StaffProfile.Hide();
                PaitentRooms.Hide();
                FinancialFees.Hide();
                PatientAppointments.Show();

            } else if (nextform == forms.PaitentRooms) {
                ReceptionistMain.Hide();
                PatientProfile.Hide();
                StaffProfile.Hide();
                PatientAppointments.Hide();
                FinancialFees.Hide();
                PaitentRooms.Show();

            } else if (nextform == forms.FinancialFees) {
                ReceptionistMain.Hide();
                PatientProfile.Hide();
                StaffProfile.Hide();
                PatientAppointments.Hide();
                PaitentRooms.Hide();
                FinancialFees.Show();
            }
        }
    }
}
