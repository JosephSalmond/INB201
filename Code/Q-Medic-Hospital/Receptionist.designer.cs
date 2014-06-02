namespace Q_Medic_Hospital
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterCheckId = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.EnterPatientAddress = new System.Windows.Forms.TextBox();
            this.patient = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.EnterpatientLastName = new System.Windows.Forms.TextBox();
            this.EnterPatientFirstName = new System.Windows.Forms.TextBox();
            this.EnterPatiendId = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.DarkViolet;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(262, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to patient appointments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(743, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check more of patients details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(743, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Go to Patient financial fees";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffProfileToolStripMenuItem,
            this.addNewFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // staffProfileToolStripMenuItem
            // 
            this.staffProfileToolStripMenuItem.Name = "staffProfileToolStripMenuItem";
            this.staffProfileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.staffProfileToolStripMenuItem.Text = "Staff Profile";
            this.staffProfileToolStripMenuItem.Click += new System.EventHandler(this.staffProfileToolStripMenuItem_Click);
            // 
            // addNewFileToolStripMenuItem
            // 
            this.addNewFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientFileToolStripMenuItem});
            this.addNewFileToolStripMenuItem.Name = "addNewFileToolStripMenuItem";
            this.addNewFileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addNewFileToolStripMenuItem.Text = "Add new file";
            // 
            // addNewPatientFileToolStripMenuItem
            // 
            this.addNewPatientFileToolStripMenuItem.Name = "addNewPatientFileToolStripMenuItem";
            this.addNewPatientFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewPatientFileToolStripMenuItem.Text = "Add new patient file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(262, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Go to patient allocated room";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 231);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 686);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 11;
            // 
            // EnterCheckId
            // 
            this.EnterCheckId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCheckId.Location = new System.Drawing.Point(826, 246);
            this.EnterCheckId.Name = "EnterCheckId";
            this.EnterCheckId.Size = new System.Drawing.Size(122, 28);
            this.EnterCheckId.TabIndex = 159;
            this.EnterCheckId.Text = "Enter";
            this.EnterCheckId.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(534, 33);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(156, 23);
            this.label46.TabIndex = 158;
            this.label46.Text = "Search for patient";
            // 
            // EnterPatientAddress
            // 
            this.EnterPatientAddress.Location = new System.Drawing.Point(835, 193);
            this.EnterPatientAddress.Name = "EnterPatientAddress";
            this.EnterPatientAddress.Size = new System.Drawing.Size(135, 20);
            this.EnterPatientAddress.TabIndex = 157;
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(258, 130);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(121, 19);
            this.patient.TabIndex = 155;
            this.patient.Text = "Patient Last Name";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(584, 192);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(31, 19);
            this.label43.TabIndex = 154;
            this.label43.Text = "OR";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(584, 130);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(31, 19);
            this.label42.TabIndex = 153;
            this.label42.Text = "OR";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(584, 74);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 19);
            this.label41.TabIndex = 152;
            this.label41.Text = "OR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 149;
            this.label9.Text = "Patient ID:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(651, 192);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 19);
            this.label31.TabIndex = 143;
            this.label31.Text = "Patient address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(651, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(141, 19);
            this.label30.TabIndex = 142;
            this.label30.Text = "Patient Phone number";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(651, 74);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(122, 19);
            this.label29.TabIndex = 141;
            this.label29.Text = "Patient First Name";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(258, 73);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 19);
            this.label28.TabIndex = 140;
            this.label28.Text = "Enter Patient ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 139;
            this.label6.Text = "Patient Profile";
            // 
            // EnterPatientPhoneNumber
            // 
            this.EnterPatientPhoneNumber.Location = new System.Drawing.Point(835, 131);
            this.EnterPatientPhoneNumber.Name = "EnterPatientPhoneNumber";
            this.EnterPatientPhoneNumber.Size = new System.Drawing.Size(135, 20);
            this.EnterPatientPhoneNumber.TabIndex = 138;
            // 
            // EnterpatientLastName
            // 
            this.EnterpatientLastName.Location = new System.Drawing.Point(422, 129);
            this.EnterpatientLastName.Name = "EnterpatientLastName";
            this.EnterpatientLastName.Size = new System.Drawing.Size(135, 20);
            this.EnterpatientLastName.TabIndex = 137;
            // 
            // EnterPatientFirstName
            // 
            this.EnterPatientFirstName.Location = new System.Drawing.Point(835, 72);
            this.EnterPatientFirstName.Name = "EnterPatientFirstName";
            this.EnterPatientFirstName.Size = new System.Drawing.Size(135, 20);
            this.EnterPatientFirstName.TabIndex = 136;
            // 
            // EnterPatiendId
            // 
            this.EnterPatiendId.Location = new System.Drawing.Point(422, 73);
            this.EnterPatiendId.Name = "EnterPatiendId";
            this.EnterPatiendId.Size = new System.Drawing.Size(135, 20);
            this.EnterPatiendId.TabIndex = 135;
            this.EnterPatiendId.TextChanged += new System.EventHandler(this.EnterPatiendId_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 682);
            this.shapeContainer1.TabIndex = 160;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(236, 299);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(766, 380);
            this.rectangleShape2.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(236, 25);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(766, 271);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 161;
            this.label2.Text = "Patient email address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 177;
            this.label3.Text = "Patient email address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 173;
            this.label7.Text = "OR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(651, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 19);
            this.label13.TabIndex = 168;
            this.label13.Text = "Patient First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 167;
            this.label14.Text = "Enter Patient ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 494);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 178;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 19);
            this.label10.TabIndex = 171;
            this.label10.Text = "OR";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(835, 496);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 175;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(422, 376);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(135, 20);
            this.textBox8.TabIndex = 163;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(651, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 19);
            this.label12.TabIndex = 169;
            this.label12.Text = "Patient Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 174;
            this.label5.Text = "Patient Last Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(835, 434);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 20);
            this.textBox5.TabIndex = 166;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(835, 375);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 172;
            this.label8.Text = "OR";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(422, 432);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 165;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(651, 495);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 170;
            this.label11.Text = "Patient address";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(234, 44);
            this.button5.TabIndex = 179;
            this.button5.Text = "Go to patient rooms";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 518);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 46);
            this.button6.TabIndex = 180;
            this.button6.Text = "Go to patients appointments";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 583);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(234, 43);
            this.button7.TabIndex = 181;
            this.button7.Text = "Go to patient details";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 646);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(234, 44);
            this.button8.TabIndex = 182;
            this.button8.Text = "Go to financial fees";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterCheckId);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.EnterPatientAddress);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnterPatientPhoneNumber);
            this.Controls.Add(this.EnterpatientLastName);
            this.Controls.Add(this.EnterPatientFirstName);
            this.Controls.Add(this.EnterPatiendId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem addNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientFileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnterCheckId;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox EnterPatientAddress;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnterPatientPhoneNumber;
        private System.Windows.Forms.TextBox EnterpatientLastName;
        private System.Windows.Forms.TextBox EnterPatientFirstName;
        private System.Windows.Forms.TextBox EnterPatiendId;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffProfileToolStripMenuItem;
    }
}

