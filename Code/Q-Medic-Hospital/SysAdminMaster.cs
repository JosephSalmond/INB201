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
    public partial class SysAdminMaster : Form
    {
        public enum forms { SysAdminMain,  StaffProfile, Complaints };
        Form SysAdminMain,  StaffProfile, Complaints;
        public int PaitentID;

        public SysAdminMaster()
        {
            
            InitializeComponent();
            SysAdminMain = new Q_Medic_Hospital.Systems_Admin();
            StaffProfile = new Q_Medic_Hospital.Staff_details();
            Complaints = new Q_Medic_Hospital.Patient_Complaint();

            SysAdminMain.WindowState = FormWindowState.Maximized;
            StaffProfile.WindowState = FormWindowState.Maximized;
            Complaints.WindowState = FormWindowState.Maximized;

            SysAdminMain.MdiParent = this;
            StaffProfile.MdiParent = this;
            Complaints.MdiParent = this;

            SysAdminMain.Show();
            }

        private void NurseMaster_Load(object sender, EventArgs e) {

        }

        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.SysAdminMain) {
                StaffProfile.Hide();
                Complaints.Hide();
                SysAdminMain.Show();
            } else if (nextform == forms.StaffProfile) {
                SysAdminMain.Hide();
                Complaints.Hide();
                StaffProfile.Show();
            } else if (nextform == forms.Complaints) {
                SysAdminMain.Hide();
                StaffProfile.Hide();
                Complaints.Show();
                
            }
        }


    }
}
