namespace McLaughingHospital
{
    partial class UCMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMenu));
            this.pnltop = new System.Windows.Forms.Panel();
            this.picb = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPat = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(207)))));
            this.pnltop.Controls.Add(this.picb);
            this.pnltop.Controls.Add(this.lblTitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(610, 59);
            this.pnltop.TabIndex = 31;
            // 
            // picb
            // 
            this.picb.Image = ((System.Drawing.Image)(resources.GetObject("picb.Image")));
            this.picb.Location = new System.Drawing.Point(198, 5);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(62, 51);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb.TabIndex = 12;
            this.picb.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(265, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Main Menu";
            // 
            // btnPat
            // 
            this.btnPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(207)))));
            this.btnPat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPat.BackgroundImage")));
            this.btnPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPat.FlatAppearance.BorderSize = 0;
            this.btnPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPat.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnPat.Location = new System.Drawing.Point(63, 204);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(223, 200);
            this.btnPat.TabIndex = 14;
            this.btnPat.Text = "Manage Patient";
            this.btnPat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPat.UseVisualStyleBackColor = false;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(207)))));
            this.btnEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.BackgroundImage")));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnEmp.Location = new System.Drawing.Point(318, 204);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(223, 200);
            this.btnEmp.TabIndex = 13;
            this.btnEmp.Text = "Manage Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(610, 599);
            this.panelContainer.TabIndex = 32;
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPat);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.panelContainer);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(610, 602);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox picb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Panel panelContainer;
    }
}
