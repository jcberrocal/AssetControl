namespace AssetControl.Forms
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsUsers = new System.Windows.Forms.ToolStrip();
            this.tsButtonUserNew = new System.Windows.Forms.ToolStripButton();
            this.tsUserSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonUserEdit = new System.Windows.Forms.ToolStripButton();
            this.tsUserSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonUserEndate = new System.Windows.Forms.ToolStripButton();
            this.tsUserSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.lblRoleUser = new System.Windows.Forms.Label();
            this.cbUserRoles = new System.Windows.Forms.ComboBox();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFilterSection.SuspendLayout();
            this.pnlDataSection.SuspendLayout();
            this.tsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.Controls.Add(this.cbUserRoles);
            this.pnlFilterSection.Controls.Add(this.lblRoleUser);
            this.pnlFilterSection.Controls.Add(this.btnSearchUser);
            this.pnlFilterSection.Controls.Add(this.txtUserName);
            this.pnlFilterSection.Controls.Add(this.lblUserName);
            this.pnlFilterSection.Controls.Add(this.chkActiveOnly);
            this.pnlFilterSection.Controls.Add(this.tsUsers);
            // 
            // pnlDataSection
            // 
            this.pnlDataSection.Controls.Add(this.dtgUsers);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(383, 9);
            this.lblTitle.Size = new System.Drawing.Size(310, 24);
            this.lblTitle.Text = "Mantenimiento de Usuarios";
            // 
            // tsUsers
            // 
            this.tsUsers.AutoSize = false;
            this.tsUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonUserNew,
            this.tsUserSeparator1,
            this.tsButtonUserEdit,
            this.tsUserSeparator2,
            this.tsButtonUserEndate,
            this.tsUserSeparator3});
            this.tsUsers.Location = new System.Drawing.Point(0, 83);
            this.tsUsers.Name = "tsUsers";
            this.tsUsers.Size = new System.Drawing.Size(1052, 36);
            this.tsUsers.TabIndex = 1;
            this.tsUsers.Text = "toolStrip1";
            // 
            // tsButtonUserNew
            // 
            this.tsButtonUserNew.AutoSize = false;
            this.tsButtonUserNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonUserNew.Image = global::AssetControl.Properties.Resources.new_32;
            this.tsButtonUserNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonUserNew.Name = "tsButtonUserNew";
            this.tsButtonUserNew.Size = new System.Drawing.Size(51, 36);
            this.tsButtonUserNew.Text = "Nuevo";
            this.tsButtonUserNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonUserNew.Click += new System.EventHandler(this.tsButtonUserNew_Click);
            // 
            // tsUserSeparator1
            // 
            this.tsUserSeparator1.Name = "tsUserSeparator1";
            this.tsUserSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonUserEdit
            // 
            this.tsButtonUserEdit.AutoSize = false;
            this.tsButtonUserEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonUserEdit.Image = global::AssetControl.Properties.Resources.edit_32;
            this.tsButtonUserEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonUserEdit.Name = "tsButtonUserEdit";
            this.tsButtonUserEdit.Size = new System.Drawing.Size(51, 36);
            this.tsButtonUserEdit.Text = "Editar";
            this.tsButtonUserEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonUserEdit.Click += new System.EventHandler(this.tsButtonUserEdit_Click);
            // 
            // tsUserSeparator2
            // 
            this.tsUserSeparator2.Name = "tsUserSeparator2";
            this.tsUserSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonUserEndate
            // 
            this.tsButtonUserEndate.AutoSize = false;
            this.tsButtonUserEndate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonUserEndate.Image = global::AssetControl.Properties.Resources.toggle_32;
            this.tsButtonUserEndate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserEndate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonUserEndate.Name = "tsButtonUserEndate";
            this.tsButtonUserEndate.Size = new System.Drawing.Size(70, 36);
            this.tsButtonUserEndate.Text = "Finalizar";
            this.tsButtonUserEndate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonUserEndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonUserEndate.Click += new System.EventHandler(this.tsButtonUserEndate_Click);
            // 
            // tsUserSeparator3
            // 
            this.tsUserSeparator3.Name = "tsUserSeparator3";
            this.tsUserSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(306, 2);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(90, 23);
            this.btnSearchUser.TabIndex = 3;
            this.btnSearchUser.Text = "Buscar(F3)";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(65, 2);
            this.txtUserName.MaxLength = 200;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 15);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Nombre:";
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Checked = true;
            this.chkActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveOnly.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiveOnly.Location = new System.Drawing.Point(402, 6);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(173, 19);
            this.chkActiveOnly.TabIndex = 5;
            this.chkActiveOnly.Text = "Sólo usuarios activos";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // lblRoleUser
            // 
            this.lblRoleUser.AutoSize = true;
            this.lblRoleUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleUser.Location = new System.Drawing.Point(3, 35);
            this.lblRoleUser.Name = "lblRoleUser";
            this.lblRoleUser.Size = new System.Drawing.Size(56, 15);
            this.lblRoleUser.TabIndex = 9;
            this.lblRoleUser.Text = "Perfil:";
            // 
            // cbUserRoles
            // 
            this.cbUserRoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUserRoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUserRoles.DisplayMember = "RoleDescription";
            this.cbUserRoles.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserRoles.FormattingEnabled = true;
            this.cbUserRoles.Location = new System.Drawing.Point(65, 27);
            this.cbUserRoles.Name = "cbUserRoles";
            this.cbUserRoles.Size = new System.Drawing.Size(202, 23);
            this.cbUserRoles.TabIndex = 2;
            this.cbUserRoles.ValueMember = "RoleId";
            this.cbUserRoles.DropDown += new System.EventHandler(this.cbUserRoles_DropDown);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AllowUserToDeleteRows = false;
            this.dtgUsers.AutoGenerateColumns = false;
            this.dtgUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.endDate,
            this.roleDescription,
            this.role,
            this.password});
            this.dtgUsers.DataSource = this.userBindingSource;
            this.dtgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsers.Location = new System.Drawing.Point(0, 0);
            this.dtgUsers.MultiSelect = false;
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsers.Size = new System.Drawing.Size(1052, 357);
            this.dtgUsers.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "UserId";
            this.userId.DividerWidth = 1;
            this.userId.HeaderText = "Id";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "UserName";
            this.userName.DividerWidth = 1;
            this.userName.HeaderText = "Nombre";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 350;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "EndDate";
            this.endDate.DividerWidth = 1;
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 150;
            // 
            // roleDescription
            // 
            this.roleDescription.DataPropertyName = "RoleDescription";
            this.roleDescription.DividerWidth = 1;
            this.roleDescription.FillWeight = 150F;
            this.roleDescription.HeaderText = "Perfil";
            this.roleDescription.Name = "roleDescription";
            this.roleDescription.ReadOnly = true;
            this.roleDescription.Width = 150;
            // 
            // role
            // 
            this.role.DataPropertyName = "Role";
            this.role.DividerWidth = 1;
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.DividerWidth = 1;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AssetControl.Classes.User);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Usuarios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsers_KeyDown);
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterSection.PerformLayout();
            this.pnlDataSection.ResumeLayout(false);
            this.tsUsers.ResumeLayout(false);
            this.tsUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsUsers;
        private System.Windows.Forms.ToolStripButton tsButtonUserNew;
        private System.Windows.Forms.ToolStripSeparator tsUserSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonUserEdit;
        private System.Windows.Forms.ToolStripSeparator tsUserSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonUserEndate;
        private System.Windows.Forms.ToolStripSeparator tsUserSeparator3;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.Label lblRoleUser;
        private System.Windows.Forms.ComboBox cbUserRoles;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}