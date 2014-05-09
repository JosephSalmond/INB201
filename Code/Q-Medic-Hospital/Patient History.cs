using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
    public partial class PatientHistoryMain : Form {
        private Form[] formation = { new Q_Medic_Hospital.PatientHistoryMain(), new Q_Medic_Hospital.PatientHistorys1(), new Q_Medic_Hospital.PatientHistorys2(), new Q_Medic_Hospital.PatientHistorys3() };
        private Form SubForm;
        private int formIndex;
        private int totalForms;

        public PatientHistoryMain() {
            InitializeComponent();
            formIndex = 0;
            totalForms = 3;
            SubForm = formation[formIndex];
            SubForm.WindowState = FormWindowState.Maximized;
            SubForm.MdiParent = this;
            SubForm.Show();
            PreviousSub.Enabled = false;
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
            if (formIndex == 0) {
                PreviousSub.Enabled = false;
            } else {
                NextSub.Enabled = true;
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
            if (formIndex == totalForms - 1) {
               NextSub.Enabled = false;
            } else {
                PreviousSub.Enabled = true;
            }
        }

        private void Nurse_Load(object sender, EventArgs e) {

        }
    }
}
