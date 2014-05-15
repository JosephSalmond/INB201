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
    public partial class NurseMaster : Form
    {
        Form SubForm;


        public NurseMaster()
        {
            InitializeComponent();
            SubForm = new Q_Medic_Hospital.NurseMainPage();
            SubForm.WindowState = FormWindowState.Maximized;
            SubForm.MdiParent = this;
            SubForm.Show();
            }


        public void ChangeForm() {
        }
    }
}
