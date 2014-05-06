using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
    public partial class Nurse : Form {
        private Form[] formation = { new Q_Medic_Hospital.PaitentHistorys(), new Q_Medic_Hospital.NurseCheckilst1(), new Q_Medic_Hospital.NurseCheckilst2() };
        private Form SubForm;
        private int formIndex;
        private int totalForms;

        public Nurse() {
            InitializeComponent();
            formIndex = 0;
            totalForms = 3;
            SubForm = formation[formIndex];
            SubForm.WindowState = FormWindowState.Maximized;
            SubForm.MdiParent = this;
            SubForm.Show();
        }


        private void Previous_Click_1(object sender, EventArgs e) {
formIndex--;
            if (formIndex > -1) {
                SubForm.Hide();
                SubForm = formation[formIndex];
                SubForm.MdiParent = this;
                SubForm.WindowState = FormWindowState.Maximized;
                SubForm.Show();
            } else {
                formIndex++;
            }
        }

        private void NextSub_Click(object sender, EventArgs e) {
       formIndex++;
            if (formIndex < totalForms) {
                SubForm.Hide();
                SubForm = formation[formIndex];
                SubForm.WindowState = FormWindowState.Maximized;
                SubForm.MdiParent = this;
                SubForm.Show();
            } else {
                formIndex--;
            }
        }
    }
}
