using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Medic_GUI {
	private void init(){
		InitializeComponent(); // ?
		this.menuStrip0 = new System.Windows.Forms.MenuStrip();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//
	}



	// Form types
	private SystemAdminRegistryForm sysadminRegistry; // seperate for system admin = our tutor
	private StaffRegistryForm staffRegistry;
	private LoginForm login;
	private DocDiagnosisForm diagnosis;
	private NurseObservationForm observation;

	// User session - logged in.
	private boolean isAdmin; // seperate for sysadmin because he has registry confirmations pending.
	private boolean isLogged;

	public partial class Login : Form {
		public Login() {
			
			// For designer.
			private System.ComponentModel.IContainer parts = null;

		}
	}


		
	}
}
