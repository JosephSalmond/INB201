namespace Q_Medic_Hospital
{
    partial class Hospital_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital_Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clerksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PatientBox = new System.Windows.Forms.TextBox();
            this.PatientID = new System.Windows.Forms.Label();
            this.PatientViewBTN = new System.Windows.Forms.Button();
            this.ExportPaitentDetails = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDaysFinances = new System.Windows.Forms.Button();
            this.PaitentFinances = new System.Windows.Forms.Button();
            this.PaitentTreatments = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffProfileToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffProfileToolStripMenuItem
            // 
            this.staffProfileToolStripMenuItem.Name = "staffProfileToolStripMenuItem";
            this.staffProfileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.staffProfileToolStripMenuItem.Text = "Staff Profile";
            this.staffProfileToolStripMenuItem.Click += new System.EventHandler(this.staffProfileToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Text = "2013";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem3.Text = "2012";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem4.Text = "2011";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem5.Text = "2010";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentToolStripMenuItem,
            this.electricityToolStripMenuItem,
            this.waterToolStripMenuItem,
            this.internetToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.rentToolStripMenuItem.Text = "Rent";
            // 
            // electricityToolStripMenuItem
            // 
            this.electricityToolStripMenuItem.Name = "electricityToolStripMenuItem";
            this.electricityToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.electricityToolStripMenuItem.Text = "Electricity";
            // 
            // waterToolStripMenuItem
            // 
            this.waterToolStripMenuItem.Name = "waterToolStripMenuItem";
            this.waterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.waterToolStripMenuItem.Text = "Water";
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.internetToolStripMenuItem.Text = "Internet";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.nursesToolStripMenuItem,
            this.receptionistToolStripMenuItem,
            this.clerksToolStripMenuItem,
            this.otherStaffToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nursesToolStripMenuItem.Text = "Nurses";
            // 
            // receptionistToolStripMenuItem
            // 
            this.receptionistToolStripMenuItem.Name = "receptionistToolStripMenuItem";
            this.receptionistToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.receptionistToolStripMenuItem.Text = "Receptionist";
            // 
            // clerksToolStripMenuItem
            // 
            this.clerksToolStripMenuItem.Name = "clerksToolStripMenuItem";
            this.clerksToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clerksToolStripMenuItem.Text = "Clerks";
            // 
            // otherStaffToolStripMenuItem
            // 
            this.otherStaffToolStripMenuItem.Name = "otherStaffToolStripMenuItem";
            this.otherStaffToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.otherStaffToolStripMenuItem.Text = "Other staff";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today\'s summary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Location = new System.Drawing.Point(356, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 82);
            this.panel1.TabIndex = 2;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(630, 2);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Location = new System.Drawing.Point(356, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 81);
            this.panel2.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(630, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Income";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 191);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PatientBox
            // 
            this.PatientBox.Location = new System.Drawing.Point(357, 37);
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(100, 20);
            this.PatientBox.TabIndex = 7;
            this.PatientBox.TextChanged += new System.EventHandler(this.PatientBox_TextChanged);
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Location = new System.Drawing.Point(300, 40);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(51, 13);
            this.PatientID.TabIndex = 8;
            this.PatientID.Text = "PatientID";
            this.PatientID.Click += new System.EventHandler(this.label4_Click);
            // 
            // PatientViewBTN
            // 
            this.PatientViewBTN.Location = new System.Drawing.Point(454, 37);
            this.PatientViewBTN.Name = "PatientViewBTN";
            this.PatientViewBTN.Size = new System.Drawing.Size(75, 20);
            this.PatientViewBTN.TabIndex = 9;
            this.PatientViewBTN.Text = "View";
            this.PatientViewBTN.UseVisualStyleBackColor = true;
            this.PatientViewBTN.Click += new System.EventHandler(this.PatientViewBTN_Click);
            // 
            // ExportPaitentDetails
            // 
            this.ExportPaitentDetails.Location = new System.Drawing.Point(344, 89);
            this.ExportPaitentDetails.Name = "ExportPaitentDetails";
            this.ExportPaitentDetails.Size = new System.Drawing.Size(128, 23);
            this.ExportPaitentDetails.TabIndex = 10;
            this.ExportPaitentDetails.Text = "Paitent Contact Details";
            this.ExportPaitentDetails.UseVisualStyleBackColor = true;
            this.ExportPaitentDetails.Click += new System.EventHandler(this.ExportPaitentDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Export To PDF";
            // 
            // ToDaysFinances
            // 
            this.ToDaysFinances.Location = new System.Drawing.Point(498, 90);
            this.ToDaysFinances.Name = "ToDaysFinances";
            this.ToDaysFinances.Size = new System.Drawing.Size(128, 23);
            this.ToDaysFinances.TabIndex = 12;
            this.ToDaysFinances.Text = "Export Finances";
            this.ToDaysFinances.UseVisualStyleBackColor = true;
            this.ToDaysFinances.Click += new System.EventHandler(this.ToDaysFinances_Click);
            // 
            // PaitentFinances
            // 
            this.PaitentFinances.Location = new System.Drawing.Point(344, 119);
            this.PaitentFinances.Name = "PaitentFinances";
            this.PaitentFinances.Size = new System.Drawing.Size(128, 23);
            this.PaitentFinances.TabIndex = 13;
            this.PaitentFinances.Text = "Paitent Finances";
            this.PaitentFinances.UseVisualStyleBackColor = true;
            this.PaitentFinances.Click += new System.EventHandler(this.PaitentFinances_Click);
            // 
            // PaitentTreatments
            // 
            this.PaitentTreatments.Location = new System.Drawing.Point(498, 119);
            this.PaitentTreatments.Name = "PaitentTreatments";
            this.PaitentTreatments.Size = new System.Drawing.Size(128, 23);
            this.PaitentTreatments.TabIndex = 14;
            this.PaitentTreatments.Text = "Paitent Treatments";
            this.PaitentTreatments.UseVisualStyleBackColor = true;
            this.PaitentTreatments.Click += new System.EventHandler(this.PaitentTreatments_Click);
            // 
            // Hospital_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.PaitentTreatments);
            this.Controls.Add(this.PaitentFinances);
            this.Controls.Add(this.ToDaysFinances);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExportPaitentDetails);
            this.Controls.Add(this.PatientViewBTN);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.PatientBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hospital_Admin";
            this.Text = "Hospital_Admin";
            this.Load += new System.EventHandler(this.Hospital_Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptionistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clerksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherStaffToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffProfileToolStripMenuItem;
        private System.Windows.Forms.TextBox PatientBox;
        private System.Windows.Forms.Label PatientID;
        private System.Windows.Forms.Button PatientViewBTN;
        private System.Windows.Forms.Button ExportPaitentDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ToDaysFinances;
        private System.Windows.Forms.Button PaitentFinances;
        private System.Windows.Forms.Button PaitentTreatments;
    }
}