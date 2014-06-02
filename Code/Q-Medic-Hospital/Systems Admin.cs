using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital
{
    public partial class Systems_Admin : Form
    {
        public Systems_Admin()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void staffProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            ((SysAdminMaster)this.MdiParent).changeForm((int)SysAdminMaster.forms.StaffProfile);
        }

        private void Systems_Admin_Load(object sender, EventArgs e) {
            
        }
    }
}
