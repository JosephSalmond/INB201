﻿using System;
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
    public partial class Patient_Activities : Form
    {
        public Patient_Activities()
        {
            ControlBox = false;
            InitializeComponent();
            
        }

        private void Patient_Activities_Load(object sender, EventArgs e)
        {

        }

        private void Patient_Click(object sender, EventArgs e)
        {

        }

        private void nurseProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((NurseMaster)this.MdiParent).changeForm((int)NurseMaster.forms.NurseMain);
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e) {
            // updates the database
        }
    }
}
