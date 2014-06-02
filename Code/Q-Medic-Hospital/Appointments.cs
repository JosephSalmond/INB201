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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doctorsAppointmentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Search for Patient appointments By patient Id
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.MdiParent is NurseMaster) {
                ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.NurseMain);
            } else if (this.MdiParent is DoctorMaster) {
                ((DoctorMaster)this.MdiParent).changeForm((int)DoctorMaster.forms.DoctorMain);
            } else if (this.MdiParent is HospitalAdminMaster) {
                ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.HospitalAdminMain);
            } else if (this.MdiParent is SysAdminMaster) {
                ((SysAdminMaster)this.MdiParent).changeForm((int)SysAdminMaster.forms.SysAdminMain);
            } else if (this.MdiParent is ReceptionistMaster) {
                ((ReceptionistMaster)this.MdiParent).changeForm((int)ReceptionistMaster.forms.ReceptionistMain);
            }
        }
    }
}
