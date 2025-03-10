namespace AssetControl.Forms
{
    partial class frmUserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEdit));
            this.lblTitleUserEdit = new System.Windows.Forms.Label();
            this.btnCancelUserEdit = new System.Windows.Forms.Button();
            this.btnOkUserEdit = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserIdEdit = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelpUserId = new System.Windows.Forms.Button();
            this.btnHelpUserName = new System.Windows.Forms.Button();
            this.bntHelpPassword = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserNameEdit = new System.Windows.Forms.TextBox();
            this.txtUserRoleEdit = new System.Windows.Forms.Label();
            this.cbUserRolesEdit = new System.Windows.Forms.ComboBox();
            this.lblPasswordConfirmEdit = new System.Windows.Forms.Label();
            this.lblPasswordEdit = new System.Windows.Forms.Label();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitleUserEdit
            // 
            this.lblTitleUserEdit.AutoSize = true;
            this.lblTitleUserEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUserEdit.Location = new System.Drawing.Point(84, 15);
            this.lblTitleUserEdit.Name = "lblTitleUserEdit";
            this.lblTitleUserEdit.Size = new System.Drawing.Size(178, 24);
            this.lblTitleUserEdit.TabIndex = 1;
            this.lblTitleUserEdit.Text = "Editar Usuario";
            // 
            // btnCancelUserEdit
            // 
            this.btnCancelUserEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUserEdit.Location = new System.Drawing.Point(165, 205);
            this.btnCancelUserEdit.Name = "btnCancelUserEdit";
            this.btnCancelUserEdit.Size = new System.Drawing.Size(90, 25);
            this.btnCancelUserEdit.TabIndex = 7;
            this.btnCancelUserEdit.Text = "Cancelar";
            this.btnCancelUserEdit.UseVisualStyleBackColor = true;
            this.btnCancelUserEdit.Click += new System.EventHandler(this.btnCancelAssetTypeEdit_Click);
            // 
            // btnOkUserEdit
            // 
            this.btnOkUserEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkUserEdit.Location = new System.Drawing.Point(59, 205);
            this.btnOkUserEdit.Name = "btnOkUserEdit";
            this.btnOkUserEdit.Size = new System.Drawing.Size(90, 25);
            this.btnOkUserEdit.TabIndex = 6;
            this.btnOkUserEdit.Text = "Guardar";
            this.btnOkUserEdit.UseVisualStyleBackColor = true;
            this.btnOkUserEdit.Click += new System.EventHandler(this.btnOkUserEdit_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(20, 55);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(63, 15);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Usuario:";
            // 
            // txtUserIdEdit
            // 
            this.txtUserIdEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUserIdEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIdEdit.Location = new System.Drawing.Point(102, 47);
            this.txtUserIdEdit.MaxLength = 200;
            this.txtUserIdEdit.Name = "txtUserIdEdit";
            this.txtUserIdEdit.Size = new System.Drawing.Size(179, 23);
            this.txtUserIdEdit.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 8000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // btnHelpUserId
            // 
            this.btnHelpUserId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpUserId.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpUserId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpUserId.BackgroundImage")));
            this.btnHelpUserId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpUserId.FlatAppearance.BorderSize = 0;
            this.btnHelpUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpUserId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpUserId.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpUserId.Location = new System.Drawing.Point(287, 51);
            this.btnHelpUserId.Name = "btnHelpUserId";
            this.btnHelpUserId.Size = new System.Drawing.Size(16, 16);
            this.btnHelpUserId.TabIndex = 0;
            this.btnHelpUserId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpUserId, resources.GetString("btnHelpUserId.ToolTip"));
            this.btnHelpUserId.UseVisualStyleBackColor = false;
            // 
            // btnHelpUserName
            // 
            this.btnHelpUserName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpUserName.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpUserName.BackgroundImage")));
            this.btnHelpUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpUserName.FlatAppearance.BorderSize = 0;
            this.btnHelpUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpUserName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpUserName.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpUserName.Location = new System.Drawing.Point(287, 81);
            this.btnHelpUserName.Name = "btnHelpUserName";
            this.btnHelpUserName.Size = new System.Drawing.Size(16, 16);
            this.btnHelpUserName.TabIndex = 0;
            this.btnHelpUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpUserName, "Nombre completo\r\n(Juan Pérez Vargas)");
            this.btnHelpUserName.UseVisualStyleBackColor = false;
            // 
            // bntHelpPassword
            // 
            this.bntHelpPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntHelpPassword.BackColor = System.Drawing.Color.Transparent;
            this.bntHelpPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntHelpPassword.BackgroundImage")));
            this.bntHelpPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntHelpPassword.FlatAppearance.BorderSize = 0;
            this.bntHelpPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHelpPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHelpPassword.ForeColor = System.Drawing.Color.Transparent;
            this.bntHelpPassword.Location = new System.Drawing.Point(287, 141);
            this.bntHelpPassword.Name = "bntHelpPassword";
            this.bntHelpPassword.Size = new System.Drawing.Size(16, 16);
            this.bntHelpPassword.TabIndex = 0;
            this.bntHelpPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.bntHelpPassword, "La contraseña por defecto para\r\nnuevos usuarios es 12345");
            this.bntHelpPassword.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(20, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nombre:";
            // 
            // txtUserNameEdit
            // 
            this.txtUserNameEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUserNameEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameEdit.Location = new System.Drawing.Point(102, 77);
            this.txtUserNameEdit.MaxLength = 200;
            this.txtUserNameEdit.Name = "txtUserNameEdit";
            this.txtUserNameEdit.Size = new System.Drawing.Size(179, 23);
            this.txtUserNameEdit.TabIndex = 1;
            // 
            // txtUserRoleEdit
            // 
            this.txtUserRoleEdit.AutoSize = true;
            this.txtUserRoleEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRoleEdit.Location = new System.Drawing.Point(20, 115);
            this.txtUserRoleEdit.Name = "txtUserRoleEdit";
            this.txtUserRoleEdit.Size = new System.Drawing.Size(56, 15);
            this.txtUserRoleEdit.TabIndex = 0;
            this.txtUserRoleEdit.Text = "Perfil:";
            // 
            // cbUserRolesEdit
            // 
            this.cbUserRolesEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbUserRolesEdit.DisplayMember = "RoleDescription";
            this.cbUserRolesEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserRolesEdit.FormattingEnabled = true;
            this.cbUserRolesEdit.Location = new System.Drawing.Point(102, 107);
            this.cbUserRolesEdit.Name = "cbUserRolesEdit";
            this.cbUserRolesEdit.Size = new System.Drawing.Size(179, 23);
            this.cbUserRolesEdit.TabIndex = 2;
            this.cbUserRolesEdit.ValueMember = "RoleId";
            // 
            // lblPasswordConfirmEdit
            // 
            this.lblPasswordConfirmEdit.AutoSize = true;
            this.lblPasswordConfirmEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirmEdit.Location = new System.Drawing.Point(20, 175);
            this.lblPasswordConfirmEdit.Name = "lblPasswordConfirmEdit";
            this.lblPasswordConfirmEdit.Size = new System.Drawing.Size(70, 15);
            this.lblPasswordConfirmEdit.TabIndex = 0;
            this.lblPasswordConfirmEdit.Text = "Confirme:";
            // 
            // lblPasswordEdit
            // 
            this.lblPasswordEdit.AutoSize = true;
            this.lblPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordEdit.Location = new System.Drawing.Point(20, 145);
            this.lblPasswordEdit.Name = "lblPasswordEdit";
            this.lblPasswordEdit.Size = new System.Drawing.Size(84, 15);
            this.lblPasswordEdit.TabIndex = 0;
            this.lblPasswordEdit.Text = "Contraseña:";
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordEdit.Location = new System.Drawing.Point(102, 137);
            this.txtPasswordEdit.MaxLength = 200;
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.PasswordChar = '*';
            this.txtPasswordEdit.Size = new System.Drawing.Size(179, 23);
            this.txtPasswordEdit.TabIndex = 3;
            this.txtPasswordEdit.Text = "12345";
            // 
            // txtPasswordConfirmEdit
            // 
            this.txtPasswordConfirmEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtPasswordConfirmEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmEdit.Location = new System.Drawing.Point(102, 167);
            this.txtPasswordConfirmEdit.MaxLength = 200;
            this.txtPasswordConfirmEdit.Name = "txtPasswordConfirmEdit";
            this.txtPasswordConfirmEdit.PasswordChar = '*';
            this.txtPasswordConfirmEdit.Size = new System.Drawing.Size(179, 23);
            this.txtPasswordConfirmEdit.TabIndex = 4;
            this.txtPasswordConfirmEdit.Text = "12345";
            // 
            // frmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 241);
            this.Controls.Add(this.bntHelpPassword);
            this.Controls.Add(this.txtPasswordConfirmEdit);
            this.Controls.Add(this.txtPasswordEdit);
            this.Controls.Add(this.lblPasswordEdit);
            this.Controls.Add(this.lblPasswordConfirmEdit);
            this.Controls.Add(this.cbUserRolesEdit);
            this.Controls.Add(this.txtUserRoleEdit);
            this.Controls.Add(this.btnHelpUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserNameEdit);
            this.Controls.Add(this.btnHelpUserId);
            this.Controls.Add(this.btnCancelUserEdit);
            this.Controls.Add(this.btnOkUserEdit);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserIdEdit);
            this.Controls.Add(this.lblTitleUserEdit);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserEdit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUserEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleUserEdit;
        private System.Windows.Forms.Button btnCancelUserEdit;
        private System.Windows.Forms.Button btnOkUserEdit;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserIdEdit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnHelpUserId;
        private System.Windows.Forms.Button btnHelpUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserNameEdit;
        private System.Windows.Forms.Label txtUserRoleEdit;
        private System.Windows.Forms.ComboBox cbUserRolesEdit;
        private System.Windows.Forms.Label lblPasswordConfirmEdit;
        private System.Windows.Forms.Label lblPasswordEdit;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.TextBox txtPasswordConfirmEdit;
        private System.Windows.Forms.Button bntHelpPassword;
    }
}