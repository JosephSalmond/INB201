using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q_Medic_Hospital
{
    public partial class Doctor : Form
    {

        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNB201DataSet.DoctorsAppointments' table. You can move, or remove it, as needed.
            this.doctorsAppointmentsTableAdapter.Fill(this.iNB201DataSet.DoctorsAppointments);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // paitent id
        }
        private void button1_Click(object sender, EventArgs e) {
            string searchPatientString = this.textBox1.Text;
            SqlCommand sqlCmd = new SqlCommand();

            MiddleWare.middle.OpenConnection();
            sqlCmd.CommandText = string.Format("select FirstName, LastName from Patients where PatientID = {0}", searchPatientString);
            sqlCmd.Connection = MiddleWare.middle.dbConnection;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool foundUser;
            if (reader.HasRows) {
                // What the fck. How do I return the reader results into the table below ?? 
            }
            MiddleWare.middle.CloseConnection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e) {
           ((DoctorMaster)this.MdiParent).changeForm((int)DoctorMaster.forms.StaffProfile);
        }

        private void button1_Click_1(object sender, EventArgs e) {
            try {
                ((DoctorMaster)this.MdiParent).PaitentID = Convert.ToInt32(textBox1.Text);
                ((DoctorMaster)this.MdiParent).changeForm((int)DoctorMaster.forms.PaitentProfile);
            }
            catch {
                textBox1.Text = "Number Reqired";
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Abandon All Hope He Who Dares To Tread These Forms", "Warning", MessageBoxButtons.OK);
        }
    }
}
