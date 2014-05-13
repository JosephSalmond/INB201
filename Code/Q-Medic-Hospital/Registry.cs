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
    public partial class Registry : Form
    {
        MiddleWare middle = new MiddleWare();
        public Registry()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registry_Load(object sender, EventArgs e)
        {
            userTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e) {
           middle.Register( (userType)Array.IndexOf(middle.stringUser, userTypeSelector.Text), UsernameText.Text, PasswordText.Text, FirstNameText.Text, LastNameText.Text, EmailText.Text);
        }

        private void UsernameText_TextChanged(object sender, EventArgs e) {
 
        }

        private void textBox2_TextChanged()
        {
        
        }
    }
}
