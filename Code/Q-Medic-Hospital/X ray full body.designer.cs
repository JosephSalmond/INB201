namespace Q_Medic_Hospital
{
    partial class X_ray_full_body
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X_ray_full_body));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goBackToMedicalTechintionPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cjeclAllPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 638);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToMedicalTechintionPageToolStripMenuItem,
            this.cjeclAllPartsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goBackToMedicalTechintionPageToolStripMenuItem
            // 
            this.goBackToMedicalTechintionPageToolStripMenuItem.Name = "goBackToMedicalTechintionPageToolStripMenuItem";
            this.goBackToMedicalTechintionPageToolStripMenuItem.Size = new System.Drawing.Size(207, 20);
            this.goBackToMedicalTechintionPageToolStripMenuItem.Text = "Go back to medical techintion page";
            this.goBackToMedicalTechintionPageToolStripMenuItem.Click += new System.EventHandler(this.goBackToMedicalTechintionPageToolStripMenuItem_Click);
            // 
            // cjeclAllPartsToolStripMenuItem
            // 
            this.cjeclAllPartsToolStripMenuItem.Name = "cjeclAllPartsToolStripMenuItem";
            this.cjeclAllPartsToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.cjeclAllPartsToolStripMenuItem.Text = "Go to X ray human parts";
            this.cjeclAllPartsToolStripMenuItem.Click += new System.EventHandler(this.cjeclAllPartsToolStripMenuItem_Click);
            // 
            // X_ray_full_body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "X_ray_full_body";
            this.Text = "X_ray_full_body";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cjeclAllPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToMedicalTechintionPageToolStripMenuItem;
    }
}