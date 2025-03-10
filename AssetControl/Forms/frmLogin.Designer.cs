
namespace AssetControl.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblParroquia = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lnlTitle1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.pbUserLogin = new System.Windows.Forms.PictureBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.pbPasswordLogin = new System.Windows.Forms.PictureBox();
            this.pnlPasswordLogin = new System.Windows.Forms.Panel();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.btnEnterLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnSettingsLogin = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlUserLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordLogin)).BeginInit();
            this.pnlPasswordLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblUbicacion);
            this.pnlLeft.Controls.Add(this.lblParroquia);
            this.pnlLeft.Controls.Add(this.lblAbout);
            this.pnlLeft.Controls.Add(this.lnlTitle1);
            this.pnlLeft.Controls.Add(this.pbLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(375, 300);
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLeft_MouseDown);
            this.pnlLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLeft_MouseMove);
            this.pnlLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlLeft_MouseUp);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(2, 223);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(0, 18);
            this.lblUbicacion.TabIndex = 4;
            // 
            // lblParroquia
            // 
            this.lblParroquia.AutoSize = true;
            this.lblParroquia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParroquia.Location = new System.Drawing.Point(2, 193);
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(96, 18);
            this.lblParroquia.TabIndex = 3;
            this.lblParroquia.Text = "Parroquia: ";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(137, 278);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(235, 13);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "Desarrollado por: Juan Carlos Berrocal";
            // 
            // lnlTitle1
            // 
            this.lnlTitle1.AutoSize = true;
            this.lnlTitle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTitle1.Location = new System.Drawing.Point(2, 163);
            this.lnlTitle1.Name = "lnlTitle1";
            this.lnlTitle1.Size = new System.Drawing.Size(270, 19);
            this.lnlTitle1.TabIndex = 1;
            this.lnlTitle1.Text = "Sistema de control de activos";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AssetControl.Properties.Resources.asset_512;
            this.pbLogo.Location = new System.Drawing.Point(61, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.BackColor = System.Drawing.Color.White;
            this.pnlUserLogin.Controls.Add(this.txtUserLogin);
            this.pnlUserLogin.Controls.Add(this.pbUserLogin);
            this.pnlUserLogin.Location = new System.Drawing.Point(374, 112);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(283, 36);
            this.pnlUserLogin.TabIndex = 2;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLogin.Location = new System.Drawing.Point(43, 8);
            this.txtUserLogin.MaxLength = 20;
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(229, 19);
            this.txtUserLogin.TabIndex = 4;
            // 
            // pbUserLogin
            // 
            this.pbUserLogin.Image = global::AssetControl.Properties.Resources.user_64;
            this.pbUserLogin.Location = new System.Drawing.Point(4, 2);
            this.pbUserLogin.Name = "pbUserLogin";
            this.pbUserLogin.Size = new System.Drawing.Size(32, 32);
            this.pbUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserLogin.TabIndex = 3;
            this.pbUserLogin.TabStop = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(42, 9);
            this.txtPasswordLogin.MaxLength = 50;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(229, 19);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // pbPasswordLogin
            // 
            this.pbPasswordLogin.Image = global::AssetControl.Properties.Resources.password_64;
            this.pbPasswordLogin.Location = new System.Drawing.Point(4, 2);
            this.pbPasswordLogin.Name = "pbPasswordLogin";
            this.pbPasswordLogin.Size = new System.Drawing.Size(32, 32);
            this.pbPasswordLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPasswordLogin.TabIndex = 3;
            this.pbPasswordLogin.TabStop = false;
            this.pbPasswordLogin.Click += new System.EventHandler(this.pbPasswordLogin_Click);
            // 
            // pnlPasswordLogin
            // 
            this.pnlPasswordLogin.BackColor = System.Drawing.Color.White;
            this.pnlPasswordLogin.Controls.Add(this.txtPasswordLogin);
            this.pnlPasswordLogin.Controls.Add(this.pbPasswordLogin);
            this.pnlPasswordLogin.Location = new System.Drawing.Point(374, 159);
            this.pnlPasswordLogin.Name = "pnlPasswordLogin";
            this.pnlPasswordLogin.Size = new System.Drawing.Size(283, 36);
            this.pnlPasswordLogin.TabIndex = 3;
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogin.Location = new System.Drawing.Point(637, 0);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(22, 22);
            this.btnCloseLogin.TabIndex = 6;
            this.btnCloseLogin.Text = "X";
            this.btnCloseLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseLogin.UseVisualStyleBackColor = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnEnterLogin
            // 
            this.btnEnterLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterLogin.Location = new System.Drawing.Point(399, 221);
            this.btnEnterLogin.Name = "btnEnterLogin";
            this.btnEnterLogin.Size = new System.Drawing.Size(100, 30);
            this.btnEnterLogin.TabIndex = 4;
            this.btnEnterLogin.Text = "Ingresar";
            this.btnEnterLogin.UseVisualStyleBackColor = true;
            this.btnEnterLogin.Click += new System.EventHandler(this.btnEnterLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Location = new System.Drawing.Point(526, 221);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(100, 30);
            this.btnCancelLogin.TabIndex = 5;
            this.btnCancelLogin.Text = "Cancelar";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnSettingsLogin
            // 
            this.btnSettingsLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettingsLogin.FlatAppearance.BorderSize = 0;
            this.btnSettingsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsLogin.Image = global::AssetControl.Properties.Resources.settings_16;
            this.btnSettingsLogin.Location = new System.Drawing.Point(639, 280);
            this.btnSettingsLogin.Name = "btnSettingsLogin";
            this.btnSettingsLogin.Size = new System.Drawing.Size(20, 20);
            this.btnSettingsLogin.TabIndex = 7;
            this.btnSettingsLogin.UseVisualStyleBackColor = true;
            this.btnSettingsLogin.Click += new System.EventHandler(this.btnSettingsLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnSettingsLogin);
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.btnEnterLogin);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.pnlPasswordLogin);
            this.Controls.Add(this.pnlUserLogin);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 300);
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordLogin)).EndInit();
            this.pnlPasswordLogin.ResumeLayout(false);
            this.pnlPasswordLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lnlTitle1;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblParroquia;
        private System.Windows.Forms.Panel pnlUserLogin;
        private System.Windows.Forms.PictureBox pbUserLogin;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.PictureBox pbPasswordLogin;
        private System.Windows.Forms.Panel pnlPasswordLogin;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnEnterLogin;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnSettingsLogin;
    }
}