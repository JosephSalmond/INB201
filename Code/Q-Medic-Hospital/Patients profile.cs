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
    public partial class PaitentProfile : Form
    {
        public PaitentProfile()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void PaitentProfile_Load(object sender, EventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Update patient profile details
        }

        private void updateMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Update my profile
        }

        private void checkMyAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Check my appointment
        }

        private void loggOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.MdiParent is DoctorMaster) {
                ((DoctorMaster)this.MdiParent).changeForm((int)DoctorMaster.forms.DoctorMain);
            } if (this.MdiParent is HospitalAdminMaster) {
                ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.HospitalAdminMain);
            }
        }
        private int getID(){
            if (this.MdiParent is DoctorMaster) {
                return ((DoctorMaster)this.MdiParent).PaitentID;
            } else if (this.MdiParent is HospitalAdminMaster) {
                return ((HospitalAdminMaster)this.MdiParent).PaitentID;
            }
            return -1;
        }
    }
}
