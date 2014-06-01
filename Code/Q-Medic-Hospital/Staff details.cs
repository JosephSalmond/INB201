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
    public partial class Staff_details : Form
    {
        public Staff_details()
        {
            InitializeComponent();
            StaffIDText.Text = MiddleWare.middle.userid + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Staff_details_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Update the stuff details
        }

        private void loggOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FirstName_TextChanged(object sender, EventArgs e) {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.MdiParent is NurseMaster){
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.NurseMain);
            } else if (this.MdiParent is DoctorMaster) {
            ((DoctorMaster)this.MdiParent).changeForm((int)DoctorMaster.forms.DoctorMain);
            }
        }

        private void StaffIDText_TextChanged(object sender, EventArgs e) {

        }
    }
}
