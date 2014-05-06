namespace Q_Medic_Hospital {
    partial class Nurse {
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
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NextSub
            // 
            this.NextSub.Location = new System.Drawing.Point(589, 0);
            this.NextSub.Name = "NextSub";
            this.NextSub.Size = new System.Drawing.Size(75, 24);
            this.NextSub.TabIndex = 3;
            this.NextSub.Text = "Next";
            this.NextSub.UseVisualStyleBackColor = true;
            this.NextSub.Click += new System.EventHandler(this.NextSub_Click);
            // 
            // PreviousSub
            // 
            this.PreviousSub.Location = new System.Drawing.Point(508, 0);
            this.PreviousSub.Name = "PreviousSub";
            this.PreviousSub.Size = new System.Drawing.Size(75, 24);
            this.PreviousSub.TabIndex = 4;
            this.PreviousSub.Text = "Previous";
            this.PreviousSub.UseVisualStyleBackColor = true;
            this.PreviousSub.Click += new System.EventHandler(this.Previous_Click_1);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.PreviousSub);
            this.Controls.Add(this.NextSub);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button NextSub;
        private System.Windows.Forms.Button PreviousSub;
    }
}