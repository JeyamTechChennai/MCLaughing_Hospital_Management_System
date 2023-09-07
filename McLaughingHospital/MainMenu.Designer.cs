namespace McLaughingHospital
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menupanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panBtnDetail = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPat = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.menupanel.Controls.Add(this.pictureBox1);
            this.menupanel.Controls.Add(this.panBtnDetail);
            this.menupanel.Controls.Add(this.btnLogout);
            this.menupanel.Controls.Add(this.btnPat);
            this.menupanel.Controls.Add(this.btnEmp);
            this.menupanel.Controls.Add(this.btnMainMenu);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(212, 766);
            this.menupanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panBtnDetail
            // 
            this.panBtnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panBtnDetail.Location = new System.Drawing.Point(0, 148);
            this.panBtnDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panBtnDetail.Name = "panBtnDetail";
            this.panBtnDetail.Size = new System.Drawing.Size(13, 148);
            this.panBtnDetail.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(13, 614);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 148);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPat
            // 
            this.btnPat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPat.BackgroundImage")));
            this.btnPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPat.FlatAppearance.BorderSize = 0;
            this.btnPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPat.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnPat.Location = new System.Drawing.Point(13, 458);
            this.btnPat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(197, 148);
            this.btnPat.TabIndex = 2;
            this.btnPat.Text = "Manage Patient";
            this.btnPat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPat.UseVisualStyleBackColor = true;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.BackgroundImage")));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnEmp.Location = new System.Drawing.Point(13, 303);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(197, 148);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Manage Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.BackgroundImage")));
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btnMainMenu.Location = new System.Drawing.Point(13, 148);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(197, 148);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(989, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(208, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(812, 766);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1020, 766);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel panBtnDetail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelContainer;
    }
}