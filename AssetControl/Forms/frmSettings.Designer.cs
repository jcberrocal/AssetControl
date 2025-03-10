namespace AssetControl.Forms
{
    partial class frmSettings
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
            this.lblTitleConfig = new System.Windows.Forms.Label();
            this.txtServerConfig = new System.Windows.Forms.TextBox();
            this.txtUserConfig = new System.Windows.Forms.TextBox();
            this.txtPasswordConfig = new System.Windows.Forms.TextBox();
            this.txtPortConfig = new System.Windows.Forms.TextBox();
            this.txtDataBaseConfig = new System.Windows.Forms.TextBox();
            this.txtParishConfig = new System.Windows.Forms.TextBox();
            this.txtAddressConfig = new System.Windows.Forms.TextBox();
            this.lblServerConfig = new System.Windows.Forms.Label();
            this.lblUserConfig = new System.Windows.Forms.Label();
            this.lblPasswordConfig = new System.Windows.Forms.Label();
            this.lblPortConfig = new System.Windows.Forms.Label();
            this.lblDatabaseConfig = new System.Windows.Forms.Label();
            this.lblParishConfig = new System.Windows.Forms.Label();
            this.lblAddressConfig = new System.Windows.Forms.Label();
            this.btnOkConfig = new System.Windows.Forms.Button();
            this.btnCancelConfig = new System.Windows.Forms.Button();
            this.btnTestConnectionConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleConfig
            // 
            this.lblTitleConfig.AutoSize = true;
            this.lblTitleConfig.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleConfig.Location = new System.Drawing.Point(69, 15);
            this.lblTitleConfig.Name = "lblTitleConfig";
            this.lblTitleConfig.Size = new System.Drawing.Size(262, 24);
            this.lblTitleConfig.TabIndex = 0;
            this.lblTitleConfig.Text = "Configuración General";
            // 
            // txtServerConfig
            // 
            this.txtServerConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerConfig.Location = new System.Drawing.Point(131, 47);
            this.txtServerConfig.Name = "txtServerConfig";
            this.txtServerConfig.Size = new System.Drawing.Size(250, 23);
            this.txtServerConfig.TabIndex = 1;
            // 
            // txtUserConfig
            // 
            this.txtUserConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserConfig.Location = new System.Drawing.Point(131, 77);
            this.txtUserConfig.Name = "txtUserConfig";
            this.txtUserConfig.Size = new System.Drawing.Size(250, 23);
            this.txtUserConfig.TabIndex = 2;
            // 
            // txtPasswordConfig
            // 
            this.txtPasswordConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfig.Location = new System.Drawing.Point(131, 107);
            this.txtPasswordConfig.Name = "txtPasswordConfig";
            this.txtPasswordConfig.PasswordChar = '*';
            this.txtPasswordConfig.Size = new System.Drawing.Size(250, 23);
            this.txtPasswordConfig.TabIndex = 3;
            // 
            // txtPortConfig
            // 
            this.txtPortConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortConfig.Location = new System.Drawing.Point(131, 137);
            this.txtPortConfig.Name = "txtPortConfig";
            this.txtPortConfig.Size = new System.Drawing.Size(250, 23);
            this.txtPortConfig.TabIndex = 4;
            // 
            // txtDataBaseConfig
            // 
            this.txtDataBaseConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBaseConfig.Location = new System.Drawing.Point(131, 167);
            this.txtDataBaseConfig.Name = "txtDataBaseConfig";
            this.txtDataBaseConfig.Size = new System.Drawing.Size(250, 23);
            this.txtDataBaseConfig.TabIndex = 5;
            // 
            // txtParishConfig
            // 
            this.txtParishConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParishConfig.Location = new System.Drawing.Point(131, 197);
            this.txtParishConfig.Name = "txtParishConfig";
            this.txtParishConfig.Size = new System.Drawing.Size(250, 23);
            this.txtParishConfig.TabIndex = 6;
            // 
            // txtAddressConfig
            // 
            this.txtAddressConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressConfig.Location = new System.Drawing.Point(131, 227);
            this.txtAddressConfig.Name = "txtAddressConfig";
            this.txtAddressConfig.Size = new System.Drawing.Size(250, 23);
            this.txtAddressConfig.TabIndex = 7;
            // 
            // lblServerConfig
            // 
            this.lblServerConfig.AutoSize = true;
            this.lblServerConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerConfig.Location = new System.Drawing.Point(20, 55);
            this.lblServerConfig.Name = "lblServerConfig";
            this.lblServerConfig.Size = new System.Drawing.Size(70, 15);
            this.lblServerConfig.TabIndex = 0;
            this.lblServerConfig.Text = "Servidor:";
            // 
            // lblUserConfig
            // 
            this.lblUserConfig.AutoSize = true;
            this.lblUserConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserConfig.Location = new System.Drawing.Point(20, 85);
            this.lblUserConfig.Name = "lblUserConfig";
            this.lblUserConfig.Size = new System.Drawing.Size(84, 15);
            this.lblUserConfig.TabIndex = 0;
            this.lblUserConfig.Text = "Usuario BD:";
            // 
            // lblPasswordConfig
            // 
            this.lblPasswordConfig.AutoSize = true;
            this.lblPasswordConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfig.Location = new System.Drawing.Point(20, 115);
            this.lblPasswordConfig.Name = "lblPasswordConfig";
            this.lblPasswordConfig.Size = new System.Drawing.Size(84, 15);
            this.lblPasswordConfig.TabIndex = 0;
            this.lblPasswordConfig.Text = "Contraseña:";
            // 
            // lblPortConfig
            // 
            this.lblPortConfig.AutoSize = true;
            this.lblPortConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortConfig.Location = new System.Drawing.Point(20, 145);
            this.lblPortConfig.Name = "lblPortConfig";
            this.lblPortConfig.Size = new System.Drawing.Size(56, 15);
            this.lblPortConfig.TabIndex = 0;
            this.lblPortConfig.Text = "Puerto:";
            // 
            // lblDatabaseConfig
            // 
            this.lblDatabaseConfig.AutoSize = true;
            this.lblDatabaseConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseConfig.Location = new System.Drawing.Point(20, 175);
            this.lblDatabaseConfig.Name = "lblDatabaseConfig";
            this.lblDatabaseConfig.Size = new System.Drawing.Size(105, 15);
            this.lblDatabaseConfig.TabIndex = 0;
            this.lblDatabaseConfig.Text = "Base de datos:";
            // 
            // lblParishConfig
            // 
            this.lblParishConfig.AutoSize = true;
            this.lblParishConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParishConfig.Location = new System.Drawing.Point(20, 205);
            this.lblParishConfig.Name = "lblParishConfig";
            this.lblParishConfig.Size = new System.Drawing.Size(77, 15);
            this.lblParishConfig.TabIndex = 0;
            this.lblParishConfig.Text = "Parroquia:";
            // 
            // lblAddressConfig
            // 
            this.lblAddressConfig.AutoSize = true;
            this.lblAddressConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressConfig.Location = new System.Drawing.Point(20, 235);
            this.lblAddressConfig.Name = "lblAddressConfig";
            this.lblAddressConfig.Size = new System.Drawing.Size(77, 15);
            this.lblAddressConfig.TabIndex = 0;
            this.lblAddressConfig.Text = "Dirección:";
            // 
            // btnOkConfig
            // 
            this.btnOkConfig.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkConfig.Location = new System.Drawing.Point(155, 263);
            this.btnOkConfig.Name = "btnOkConfig";
            this.btnOkConfig.Size = new System.Drawing.Size(90, 25);
            this.btnOkConfig.TabIndex = 15;
            this.btnOkConfig.Text = "Guardar";
            this.btnOkConfig.UseVisualStyleBackColor = true;
            this.btnOkConfig.Click += new System.EventHandler(this.btnOkConfig_Click);
            // 
            // btnCancelConfig
            // 
            this.btnCancelConfig.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelConfig.Location = new System.Drawing.Point(261, 263);
            this.btnCancelConfig.Name = "btnCancelConfig";
            this.btnCancelConfig.Size = new System.Drawing.Size(90, 25);
            this.btnCancelConfig.TabIndex = 16;
            this.btnCancelConfig.Text = "Cancelar";
            this.btnCancelConfig.UseVisualStyleBackColor = true;
            this.btnCancelConfig.Click += new System.EventHandler(this.btnCancelConfig_Click);
            // 
            // btnTestConnectionConfig
            // 
            this.btnTestConnectionConfig.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnectionConfig.Location = new System.Drawing.Point(49, 263);
            this.btnTestConnectionConfig.Name = "btnTestConnectionConfig";
            this.btnTestConnectionConfig.Size = new System.Drawing.Size(90, 25);
            this.btnTestConnectionConfig.TabIndex = 8;
            this.btnTestConnectionConfig.Text = "Probar";
            this.btnTestConnectionConfig.UseVisualStyleBackColor = true;
            this.btnTestConnectionConfig.Click += new System.EventHandler(this.btnTestConnectionConfig_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnTestConnectionConfig);
            this.Controls.Add(this.btnCancelConfig);
            this.Controls.Add(this.btnOkConfig);
            this.Controls.Add(this.lblAddressConfig);
            this.Controls.Add(this.lblParishConfig);
            this.Controls.Add(this.lblDatabaseConfig);
            this.Controls.Add(this.lblPortConfig);
            this.Controls.Add(this.lblPasswordConfig);
            this.Controls.Add(this.lblUserConfig);
            this.Controls.Add(this.lblServerConfig);
            this.Controls.Add(this.txtAddressConfig);
            this.Controls.Add(this.txtParishConfig);
            this.Controls.Add(this.txtDataBaseConfig);
            this.Controls.Add(this.txtPortConfig);
            this.Controls.Add(this.txtPasswordConfig);
            this.Controls.Add(this.txtUserConfig);
            this.Controls.Add(this.txtServerConfig);
            this.Controls.Add(this.lblTitleConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSettings_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleConfig;
        private System.Windows.Forms.TextBox txtServerConfig;
        private System.Windows.Forms.TextBox txtUserConfig;
        private System.Windows.Forms.TextBox txtPasswordConfig;
        private System.Windows.Forms.TextBox txtPortConfig;
        private System.Windows.Forms.TextBox txtDataBaseConfig;
        private System.Windows.Forms.TextBox txtParishConfig;
        private System.Windows.Forms.TextBox txtAddressConfig;
        private System.Windows.Forms.Label lblServerConfig;
        private System.Windows.Forms.Label lblUserConfig;
        private System.Windows.Forms.Label lblPasswordConfig;
        private System.Windows.Forms.Label lblPortConfig;
        private System.Windows.Forms.Label lblDatabaseConfig;
        private System.Windows.Forms.Label lblParishConfig;
        private System.Windows.Forms.Label lblAddressConfig;
        private System.Windows.Forms.Button btnOkConfig;
        private System.Windows.Forms.Button btnCancelConfig;
        private System.Windows.Forms.Button btnTestConnectionConfig;
    }
}