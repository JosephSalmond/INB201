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
    public partial class Observations : Form
    {
        Form main;
        public Observations(Form main)
        {
            this.main = main;
            ControlBox = false;
            InitializeComponent();
        }

        private void Observations_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void observationPageToolStripMenuItem_Click(object sender, EventArgs e) {
            main.Show();
            this.Close();
        }
    }
}
