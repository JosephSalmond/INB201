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
    public partial class X_ray_full_body : Form
    {
        public X_ray_full_body()
        {
            InitializeComponent();
        }

        private void cjeclAllPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MedTechMaster)this.MdiParent).changeForm((int)MedTechMaster.forms.XrayParts);
        }

        private void goBackToMedicalTechintionPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MedTechMaster)this.MdiParent).changeForm((int)MedTechMaster.forms.MedTech);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
