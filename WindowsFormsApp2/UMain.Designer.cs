namespace WindowsFormsApp2
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbDrive0 = new System.Windows.Forms.ProgressBar();
            this.tmDrives = new System.Windows.Forms.Timer(this.components);
            this.pbDrive1 = new System.Windows.Forms.ProgressBar();
            this.pbDrive2 = new System.Windows.Forms.ProgressBar();
            this.pbDrive3 = new System.Windows.Forms.ProgressBar();
            this.pbDrive4 = new System.Windows.Forms.ProgressBar();
            this.pbDrive5 = new System.Windows.Forms.ProgressBar();
            this.lblDrive0 = new System.Windows.Forms.Label();
            this.lblDrive1 = new System.Windows.Forms.Label();
            this.lblDrive2 = new System.Windows.Forms.Label();
            this.lblDrive3 = new System.Windows.Forms.Label();
            this.lblDrive4 = new System.Windows.Forms.Label();
            this.lblDrive5 = new System.Windows.Forms.Label();
            this.lblDriveInfo0 = new System.Windows.Forms.Label();
            this.lblDriveInfo1 = new System.Windows.Forms.Label();
            this.lblDriveInfo2 = new System.Windows.Forms.Label();
            this.lblDriveInfo3 = new System.Windows.Forms.Label();
            this.lblDriveInfo4 = new System.Windows.Forms.Label();
            this.lblDriveInfo5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbDrive0
            // 
            this.pbDrive0.Location = new System.Drawing.Point(95, 12);
            this.pbDrive0.MarqueeAnimationSpeed = 0;
            this.pbDrive0.Name = "pbDrive0";
            this.pbDrive0.Size = new System.Drawing.Size(376, 23);
            this.pbDrive0.Step = 1;
            this.pbDrive0.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive0.TabIndex = 0;
            // 
            // tmDrives
            // 
            this.tmDrives.Enabled = true;
            this.tmDrives.Interval = 1000;
            this.tmDrives.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbDrive1
            // 
            this.pbDrive1.Location = new System.Drawing.Point(95, 54);
            this.pbDrive1.MarqueeAnimationSpeed = 0;
            this.pbDrive1.Name = "pbDrive1";
            this.pbDrive1.Size = new System.Drawing.Size(376, 23);
            this.pbDrive1.Step = 1;
            this.pbDrive1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive1.TabIndex = 1;
            this.pbDrive1.Visible = false;
            // 
            // pbDrive2
            // 
            this.pbDrive2.Location = new System.Drawing.Point(95, 96);
            this.pbDrive2.MarqueeAnimationSpeed = 0;
            this.pbDrive2.Name = "pbDrive2";
            this.pbDrive2.Size = new System.Drawing.Size(376, 23);
            this.pbDrive2.Step = 1;
            this.pbDrive2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive2.TabIndex = 2;
            this.pbDrive2.Visible = false;
            // 
            // pbDrive3
            // 
            this.pbDrive3.Location = new System.Drawing.Point(95, 138);
            this.pbDrive3.MarqueeAnimationSpeed = 0;
            this.pbDrive3.Name = "pbDrive3";
            this.pbDrive3.Size = new System.Drawing.Size(376, 23);
            this.pbDrive3.Step = 1;
            this.pbDrive3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive3.TabIndex = 3;
            this.pbDrive3.Visible = false;
            // 
            // pbDrive4
            // 
            this.pbDrive4.Location = new System.Drawing.Point(95, 180);
            this.pbDrive4.MarqueeAnimationSpeed = 0;
            this.pbDrive4.Name = "pbDrive4";
            this.pbDrive4.Size = new System.Drawing.Size(376, 23);
            this.pbDrive4.Step = 1;
            this.pbDrive4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive4.TabIndex = 4;
            this.pbDrive4.Visible = false;
            // 
            // pbDrive5
            // 
            this.pbDrive5.Location = new System.Drawing.Point(95, 222);
            this.pbDrive5.MarqueeAnimationSpeed = 0;
            this.pbDrive5.Name = "pbDrive5";
            this.pbDrive5.Size = new System.Drawing.Size(376, 23);
            this.pbDrive5.Step = 1;
            this.pbDrive5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDrive5.TabIndex = 5;
            this.pbDrive5.Visible = false;
            // 
            // lblDrive0
            // 
            this.lblDrive0.AutoSize = true;
            this.lblDrive0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive0.Location = new System.Drawing.Point(12, 16);
            this.lblDrive0.Name = "lblDrive0";
            this.lblDrive0.Size = new System.Drawing.Size(28, 14);
            this.lblDrive0.TabIndex = 6;
            this.lblDrive0.Text = "C:\\";
            // 
            // lblDrive1
            // 
            this.lblDrive1.AutoSize = true;
            this.lblDrive1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive1.Location = new System.Drawing.Point(12, 58);
            this.lblDrive1.Name = "lblDrive1";
            this.lblDrive1.Size = new System.Drawing.Size(28, 14);
            this.lblDrive1.TabIndex = 7;
            this.lblDrive1.Text = "D:\\";
            this.lblDrive1.Visible = false;
            // 
            // lblDrive2
            // 
            this.lblDrive2.AutoSize = true;
            this.lblDrive2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive2.Location = new System.Drawing.Point(12, 100);
            this.lblDrive2.Name = "lblDrive2";
            this.lblDrive2.Size = new System.Drawing.Size(28, 14);
            this.lblDrive2.TabIndex = 8;
            this.lblDrive2.Text = "E:\\";
            this.lblDrive2.Visible = false;
            // 
            // lblDrive3
            // 
            this.lblDrive3.AutoSize = true;
            this.lblDrive3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive3.Location = new System.Drawing.Point(12, 142);
            this.lblDrive3.Name = "lblDrive3";
            this.lblDrive3.Size = new System.Drawing.Size(28, 14);
            this.lblDrive3.TabIndex = 9;
            this.lblDrive3.Text = "F:\\";
            this.lblDrive3.Visible = false;
            // 
            // lblDrive4
            // 
            this.lblDrive4.AutoSize = true;
            this.lblDrive4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive4.Location = new System.Drawing.Point(12, 184);
            this.lblDrive4.Name = "lblDrive4";
            this.lblDrive4.Size = new System.Drawing.Size(28, 14);
            this.lblDrive4.TabIndex = 10;
            this.lblDrive4.Text = "G:\\";
            this.lblDrive4.Visible = false;
            // 
            // lblDrive5
            // 
            this.lblDrive5.AutoSize = true;
            this.lblDrive5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive5.Location = new System.Drawing.Point(12, 226);
            this.lblDrive5.Name = "lblDrive5";
            this.lblDrive5.Size = new System.Drawing.Size(28, 14);
            this.lblDrive5.TabIndex = 11;
            this.lblDrive5.Text = "H:\\";
            this.lblDrive5.Visible = false;
            // 
            // lblDriveInfo0
            // 
            this.lblDriveInfo0.AutoSize = true;
            this.lblDriveInfo0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo0.Location = new System.Drawing.Point(12, 38);
            this.lblDriveInfo0.Name = "lblDriveInfo0";
            this.lblDriveInfo0.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo0.TabIndex = 12;
            this.lblDriveInfo0.Text = "lblDriveInfo1";
            // 
            // lblDriveInfo1
            // 
            this.lblDriveInfo1.AutoSize = true;
            this.lblDriveInfo1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo1.Location = new System.Drawing.Point(12, 80);
            this.lblDriveInfo1.Name = "lblDriveInfo1";
            this.lblDriveInfo1.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo1.TabIndex = 13;
            this.lblDriveInfo1.Text = "lblDriveInfo2";
            this.lblDriveInfo1.Visible = false;
            // 
            // lblDriveInfo2
            // 
            this.lblDriveInfo2.AutoSize = true;
            this.lblDriveInfo2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo2.Location = new System.Drawing.Point(12, 122);
            this.lblDriveInfo2.Name = "lblDriveInfo2";
            this.lblDriveInfo2.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo2.TabIndex = 14;
            this.lblDriveInfo2.Text = "lblDriveInfo3";
            this.lblDriveInfo2.Visible = false;
            // 
            // lblDriveInfo3
            // 
            this.lblDriveInfo3.AutoSize = true;
            this.lblDriveInfo3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo3.Location = new System.Drawing.Point(12, 164);
            this.lblDriveInfo3.Name = "lblDriveInfo3";
            this.lblDriveInfo3.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo3.TabIndex = 15;
            this.lblDriveInfo3.Text = "lblDriveInfo4";
            this.lblDriveInfo3.Visible = false;
            // 
            // lblDriveInfo4
            // 
            this.lblDriveInfo4.AutoSize = true;
            this.lblDriveInfo4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo4.Location = new System.Drawing.Point(12, 206);
            this.lblDriveInfo4.Name = "lblDriveInfo4";
            this.lblDriveInfo4.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo4.TabIndex = 16;
            this.lblDriveInfo4.Text = "lblDriveInfo5";
            this.lblDriveInfo4.Visible = false;
            // 
            // lblDriveInfo5
            // 
            this.lblDriveInfo5.AutoSize = true;
            this.lblDriveInfo5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo5.Location = new System.Drawing.Point(12, 248);
            this.lblDriveInfo5.Name = "lblDriveInfo5";
            this.lblDriveInfo5.Size = new System.Drawing.Size(98, 14);
            this.lblDriveInfo5.TabIndex = 17;
            this.lblDriveInfo5.Text = "lblDriveInfo6";
            this.lblDriveInfo5.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.Controls.Add(this.lblDriveInfo5);
            this.Controls.Add(this.lblDriveInfo4);
            this.Controls.Add(this.lblDriveInfo3);
            this.Controls.Add(this.lblDriveInfo2);
            this.Controls.Add(this.lblDriveInfo1);
            this.Controls.Add(this.lblDriveInfo0);
            this.Controls.Add(this.lblDrive5);
            this.Controls.Add(this.lblDrive4);
            this.Controls.Add(this.lblDrive3);
            this.Controls.Add(this.lblDrive2);
            this.Controls.Add(this.lblDrive1);
            this.Controls.Add(this.lblDrive0);
            this.Controls.Add(this.pbDrive5);
            this.Controls.Add(this.pbDrive4);
            this.Controls.Add(this.pbDrive3);
            this.Controls.Add(this.pbDrive2);
            this.Controls.Add(this.pbDrive1);
            this.Controls.Add(this.pbDrive0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Disk Free .NET";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDrive0;
        private System.Windows.Forms.Timer tmDrives;
        private System.Windows.Forms.ProgressBar pbDrive1;
        private System.Windows.Forms.ProgressBar pbDrive2;
        private System.Windows.Forms.ProgressBar pbDrive3;
        private System.Windows.Forms.ProgressBar pbDrive4;
        private System.Windows.Forms.ProgressBar pbDrive5;
        private System.Windows.Forms.Label lblDrive0;
        private System.Windows.Forms.Label lblDrive1;
        private System.Windows.Forms.Label lblDrive2;
        private System.Windows.Forms.Label lblDrive3;
        private System.Windows.Forms.Label lblDrive4;
        private System.Windows.Forms.Label lblDrive5;
        private System.Windows.Forms.Label lblDriveInfo0;
        private System.Windows.Forms.Label lblDriveInfo1;
        private System.Windows.Forms.Label lblDriveInfo2;
        private System.Windows.Forms.Label lblDriveInfo3;
        private System.Windows.Forms.Label lblDriveInfo4;
        private System.Windows.Forms.Label lblDriveInfo5;
    }
}

