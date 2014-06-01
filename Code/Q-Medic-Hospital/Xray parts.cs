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
    public partial class Xray : Form
    {
        public Xray()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void goBackToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MedTechMaster)this.MdiParent).changeForm((int)MedTechMaster.forms.MedTech);
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updataXRayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Update x ray pictures 
        }

        private void goBackToFullBodyPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MedTechMaster)this.MdiParent).changeForm((int)MedTechMaster.forms.XrayFull);
        }

        private void Xray_Load(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
