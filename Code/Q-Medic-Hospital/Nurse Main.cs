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
    public partial class NurseMainPage : Form
    {
        public NurseMainPage()
        {
            ControlBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Observations_Click(object sender, EventArgs e) {
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.Observation);
        }

        private void HospitalBedAllocation_Click(object sender, EventArgs e) {
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.BedAllocation);
        }

        private void PatientActivites_Click(object sender, EventArgs e) {
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.PatientActivity);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MainProfile_Click(object sender, EventArgs e) {
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.StaffProfile);
        }
    }
}
