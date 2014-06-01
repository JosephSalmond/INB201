using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q_Medic_Hospital
{
    public partial class NurseMainPage : Form
    {
        SqlConnection dbConnection = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader reader;


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

            MiddleWare.middle.OpenConnection();
            Console.WriteLine("Debugging yo.");

            sqlCmd.CommandText = string.Format("SELECT NurseObservations FROM Treatment");
            sqlCmd.Connection = dbConnection;

            reader = sqlCmd.ExecuteReader();

            MiddleWare.middle.CloseConnection();
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
