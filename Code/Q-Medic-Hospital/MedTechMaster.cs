using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_Hospital {
    public partial class MedTechMaster : Form {

        public enum forms { XrayFull, XrayParts, MedTech };
        Form MedTech, XrayFull, XrayParts;

        public MedTechMaster() {
            InitializeComponent();
            MedTech = new Q_Medic_Hospital.MedTech();
            XrayFull = new Q_Medic_Hospital.X_ray_full_body();
            XrayParts = new Q_Medic_Hospital.Xray();

            MedTech.WindowState = FormWindowState.Maximized;
            XrayFull.WindowState = FormWindowState.Maximized;
            XrayParts.WindowState = FormWindowState.Maximized;

            MedTech.MdiParent = this;
            XrayFull.MdiParent = this;
            XrayParts.MdiParent = this;
            MedTech.Show();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }
        public void changeForm(int form) {
            forms nextform = (forms)form;
            if (nextform == forms.MedTech) {
                XrayFull.Hide();
                XrayParts.Hide();
                MedTech.Show();
            } else if (nextform == forms.XrayFull) {
                MedTech.Hide();
                XrayParts.Hide();
                XrayFull.Show();
            } else if (nextform == forms.XrayParts) {
                MedTech.Hide();
                XrayFull.Hide();
                XrayParts.Show();
            } 
        }
    }
}
