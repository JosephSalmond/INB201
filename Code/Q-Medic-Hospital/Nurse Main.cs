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
        Form NextForm;
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
            NextForm = new Q_Medic_Hospital.Observations(this);
            this.Hide();
            NextForm.Show();
        }

        private void HospitalBedAllocation_Click(object sender, EventArgs e) {
            NextForm = new Q_Medic_Hospital.PatientRooms(this);
            this.Hide();
            NextForm.Show();
        }

        private void PatientActivites_Click(object sender, EventArgs e) {
            NextForm = new Q_Medic_Hospital.Patient_Activities(this);
            this.Hide();
            NextForm.Show();
        }
    }
}
