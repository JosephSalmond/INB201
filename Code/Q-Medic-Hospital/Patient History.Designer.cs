namespace Q_Medic_Hospital {
    partial class PatientHistoryMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NextSub = new System.Windows.Forms.Button();
            this.PreviousSub = new System.Windows.Forms.Button();
            this.CurentPatient = new System.Windows.Forms.Label();
            this.PatientBox = new System.Windows.Forms.TextBox();
            this.PrevHospital = new System.Windows.Forms.Label();
            this.PrevHospitalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NextSub
            // 
            this.NextSub.Location = new System.Drawing.Point(921, 0);
            this.NextSub.Name = "NextSub";
            this.NextSub.Size = new System.Drawing.Size(75, 24);
            this.NextSub.TabIndex = 3;
            this.NextSub.Text = "Next";
            this.NextSub.UseVisualStyleBackColor = true;
            this.NextSub.Click += new System.EventHandler(this.NextSub_Click);
            // 
            // PreviousSub
            // 
            this.PreviousSub.Location = new System.Drawing.Point(840, 0);
            this.PreviousSub.Name = "PreviousSub";
            this.PreviousSub.Size = new System.Drawing.Size(75, 24);
            this.PreviousSub.TabIndex = 4;
            this.PreviousSub.Text = "Previous";
            this.PreviousSub.UseVisualStyleBackColor = true;
            this.PreviousSub.Click += new System.EventHandler(this.Previous_Click_1);
            // 
            // CurentPatient
            // 
            this.CurentPatient.AutoSize = true;
            this.CurentPatient.Location = new System.Drawing.Point(12, 6);
            this.CurentPatient.Margin = new System.Windows.Forms.Padding(0);
            this.CurentPatient.Name = "CurentPatient";
            this.CurentPatient.Size = new System.Drawing.Size(40, 13);
            this.CurentPatient.TabIndex = 6;
            this.CurentPatient.Text = "Patient";
            // 
            // PatientBox
            // 
            this.PatientBox.Location = new System.Drawing.Point(55, 3);
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(130, 20);
            this.PatientBox.TabIndex = 7;
            this.PatientBox.Text = "Patient name";
            // 
            // PrevHospital
            // 
            this.PrevHospital.AutoSize = true;
            this.PrevHospital.Location = new System.Drawing.Point(204, 6);
            this.PrevHospital.Name = "PrevHospital";
            this.PrevHospital.Size = new System.Drawing.Size(89, 13);
            this.PrevHospital.TabIndex = 8;
            this.PrevHospital.Text = "Previous Hospital";
            // 
            // PrevHospitalBox
            // 
            this.PrevHospitalBox.Location = new System.Drawing.Point(299, 3);
            this.PrevHospitalBox.Name = "PrevHospitalBox";
            this.PrevHospitalBox.Size = new System.Drawing.Size(180, 20);
            this.PrevHospitalBox.TabIndex = 9;
            this.PrevHospitalBox.Text = "Previous Hospital";
            // 
            // PatientHistoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PrevHospitalBox);
            this.Controls.Add(this.PrevHospital);
            this.Controls.Add(this.PatientBox);
            this.Controls.Add(this.CurentPatient);
            this.Controls.Add(this.PreviousSub);
            this.Controls.Add(this.NextSub);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientHistoryMain";
            this.Text = "Patient History";
            this.Load += new System.EventHandler(this.Nurse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button NextSub;
        private System.Windows.Forms.Button PreviousSub;
        private System.Windows.Forms.Label CurentPatient;
        private System.Windows.Forms.TextBox PatientBox;
        private System.Windows.Forms.Label PrevHospital;
        private System.Windows.Forms.TextBox PrevHospitalBox;
    }
}