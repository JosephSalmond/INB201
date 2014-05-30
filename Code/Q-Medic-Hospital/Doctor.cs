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
        MiddleWare middle = new MiddleWare();

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

        }
        private void button1_Click(object sender, EventArgs e) {
            string searchPatientString = this.textBox1.Text;
            SqlCommand sqlCmd = new SqlCommand();

            middle.OpenConnection();
            sqlCmd.CommandText = string.Format("select FirstName, LastName from Patients where PatientID = {0}", searchPatientString);
            sqlCmd.Connection = middle.dbConnection;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool foundUser;
            if (reader.HasRows) {
                // What the fck. How do I return the reader results into the table below ?? 
            }
            middle.CloseConnection();
        }
    }
}
