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
            } else if (this.MdiParent is HospitalAdminMaster) {
                ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.HospitalAdminMain);
            } else if (this.MdiParent is ReceptionistMaster) {
                ((ReceptionistMaster)this.MdiParent).changeForm((int)ReceptionistMaster.forms.ReceptionistMain);
            }
        }

        private int getID(){
            if (this.MdiParent is DoctorMaster) {
                return ((DoctorMaster)this.MdiParent).PaitentID;
            } else if (this.MdiParent is HospitalAdminMaster) {
                return ((HospitalAdminMaster)this.MdiParent).PaitentID;
            } else if (this.MdiParent is ReceptionistMaster) {
                return ((ReceptionistMaster)this.MdiParent).PaitentID;
            }
            return -1;
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
int patientID = getID();
            MiddleWare.middle.OpenConnection();
            SqlCommand sqlCmd = new SqlCommand(string.Format("select Firstname, Lastname, StreetAddress, Suburb, PostCode, MobileNumber, Email, PatientID from Patients WHERE PatientID = '{0}'", patientID), MiddleWare.middle.dbConnection);
            
           
            SqlDataReader reader;
            reader = sqlCmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                textBox1.Text = reader.GetString(0);
                textBox2.Text = reader.GetString(1);
                textBox4.Text = "13";
                textBox6.Text = reader.GetString(2);
                textBox7.Text = reader.GetString(3);
                textBox8.Text = reader.GetString(4);
                textBox10.Text = reader.GetString(5);
                textBox11.Text = reader.GetString(6);
            }
            MiddleWare.middle.CloseConnection();
        }
    }
}
