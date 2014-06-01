using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital
{
    public partial class Hospital_Admin : Form
    {
        
        public Hospital_Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hospital_Admin_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void staffProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.StaffProfile);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void PatientViewBTN_Click(object sender, EventArgs e) {
            try {
                ((HospitalAdminMaster)this.MdiParent).PaitentID = Convert.ToInt32(PatientBox.Text);
                ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.PatientProfile);
            }
            catch {
                PatientBox.Text = "Number Reqired";
            }
        }

        private void PatientBox_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
