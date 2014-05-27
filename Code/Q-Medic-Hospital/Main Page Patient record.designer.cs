namespace Patients_Record_Forms
{
    partial class Main_Page_Patient_record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page_Patient_record));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.PersonalInformation = new System.Windows.Forms.Button();
            this.InsuranceInformation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HospitalName = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PatientPicture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // PersonalInformation
            // 
            this.PersonalInformation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInformation.Location = new System.Drawing.Point(3, 181);
            this.PersonalInformation.Name = "PersonalInformation";
            this.PersonalInformation.Size = new System.Drawing.Size(227, 31);
            this.PersonalInformation.TabIndex = 3;
            this.PersonalInformation.Text = "Personal Information";
            this.PersonalInformation.UseVisualStyleBackColor = true;
            // 
            // InsuranceInformation
            // 
            this.InsuranceInformation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceInformation.Location = new System.Drawing.Point(3, 230);
            this.InsuranceInformation.Name = "InsuranceInformation";
            this.InsuranceInformation.Size = new System.Drawing.Size(227, 32);
            this.InsuranceInformation.TabIndex = 4;
            this.InsuranceInformation.Text = "Insurance Information";
            this.InsuranceInformation.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Medical Infrmation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 226);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HospitalName
            // 
            this.HospitalName.AutoSize = true;
            this.HospitalName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalName.Location = new System.Drawing.Point(252, 26);
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Size = new System.Drawing.Size(100, 19);
            this.HospitalName.TabIndex = 11;
            this.HospitalName.Text = "Hospital Name";
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(358, 26);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(91, 19);
            this.PatientName.TabIndex = 12;
            this.PatientName.Text = "Patient Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 14;
            // 
            // PatientPicture
            // 
            this.PatientPicture.AutoSize = true;
            this.PatientPicture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPicture.Location = new System.Drawing.Point(538, 26);
            this.PatientPicture.Name = "PatientPicture";
            this.PatientPicture.Size = new System.Drawing.Size(96, 19);
            this.PatientPicture.TabIndex = 15;
            this.PatientPicture.Text = "Patient Picture";
            // 
            // Main_Page_Patient_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 338);
            this.Controls.Add(this.PatientPicture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.HospitalName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InsuranceInformation);
            this.Controls.Add(this.PersonalInformation);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Main_Page_Patient_record";
            this.Text = "Main_Page_Patient_record";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button PersonalInformation;
        private System.Windows.Forms.Button InsuranceInformation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HospitalName;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PatientPicture;
    }
}