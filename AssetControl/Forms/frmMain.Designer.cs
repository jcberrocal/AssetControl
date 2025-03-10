namespace AssetControl.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAssets = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAssetType = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonBranches = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonLocations = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonReport = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonPassword = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAudit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonExit = new System.Windows.Forms.ToolStripButton();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivosDeSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserMain = new System.Windows.Forms.Label();
            this.lblRoleMain = new System.Windows.Forms.Label();
            this.btnSettingsMain = new System.Windows.Forms.Button();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.BackColor = System.Drawing.Color.White;
            this.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsMain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(12, 12);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel,
            this.tsSeparator1,
            this.tsButtonAssets,
            this.tsSeparator2,
            this.tsButtonAssetType,
            this.tsSeparator3,
            this.tsButtonBranches,
            this.tsSeparator4,
            this.tsButtonLocations,
            this.tsSeparator5,
            this.tsButtonReport,
            this.tsSeparator6,
            this.tsButtonPassword,
            this.tsSeparator7,
            this.tsButtonUsers,
            this.tsSeparator8,
            this.tsButtonAudit,
            this.tsSeparator9,
            this.tsButtonAbout,
            this.tsSeparator10,
            this.tsButtonExit});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMain.Size = new System.Drawing.Size(1080, 75);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "Menú";
            // 
            // tsLabel
            // 
            this.tsLabel.AutoSize = false;
            this.tsLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel.Image = global::AssetControl.Properties.Resources.fixed_asset_32;
            this.tsLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tsLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(210, 51);
            this.tsLabel.Text = "Control de Activos";
            this.tsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.AutoSize = false;
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonAssets
            // 
            this.tsButtonAssets.AutoSize = false;
            this.tsButtonAssets.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonAssets.Image = global::AssetControl.Properties.Resources.asset_32;
            this.tsButtonAssets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonAssets.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonAssets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAssets.Name = "tsButtonAssets";
            this.tsButtonAssets.Size = new System.Drawing.Size(65, 51);
            this.tsButtonAssets.Text = "Activos";
            this.tsButtonAssets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonAssets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAssets.ToolTipText = "Menú de activos";
            this.tsButtonAssets.Click += new System.EventHandler(this.tsButtonAssets_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.AutoSize = false;
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonAssetType
            // 
            this.tsButtonAssetType.AutoSize = false;
            this.tsButtonAssetType.Image = global::AssetControl.Properties.Resources.asset_management_32;
            this.tsButtonAssetType.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonAssetType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonAssetType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAssetType.Name = "tsButtonAssetType";
            this.tsButtonAssetType.Size = new System.Drawing.Size(65, 51);
            this.tsButtonAssetType.Text = "Tipos";
            this.tsButtonAssetType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonAssetType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAssetType.Click += new System.EventHandler(this.tsButtonAssetType_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.AutoSize = false;
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonBranches
            // 
            this.tsButtonBranches.AutoSize = false;
            this.tsButtonBranches.Image = global::AssetControl.Properties.Resources.branches_32;
            this.tsButtonBranches.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonBranches.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonBranches.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonBranches.Name = "tsButtonBranches";
            this.tsButtonBranches.Size = new System.Drawing.Size(70, 51);
            this.tsButtonBranches.Text = "Filiales";
            this.tsButtonBranches.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonBranches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonBranches.Click += new System.EventHandler(this.tsButtonBranches_Click);
            // 
            // tsSeparator4
            // 
            this.tsSeparator4.AutoSize = false;
            this.tsSeparator4.Name = "tsSeparator4";
            this.tsSeparator4.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonLocations
            // 
            this.tsButtonLocations.AutoSize = false;
            this.tsButtonLocations.Image = global::AssetControl.Properties.Resources.assetlocation_32;
            this.tsButtonLocations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonLocations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonLocations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonLocations.Name = "tsButtonLocations";
            this.tsButtonLocations.Size = new System.Drawing.Size(85, 51);
            this.tsButtonLocations.Text = "Ubicaciones";
            this.tsButtonLocations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonLocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonLocations.Click += new System.EventHandler(this.tsButtonLocations_Click);
            // 
            // tsSeparator5
            // 
            this.tsSeparator5.AutoSize = false;
            this.tsSeparator5.Name = "tsSeparator5";
            this.tsSeparator5.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonReport
            // 
            this.tsButtonReport.AutoSize = false;
            this.tsButtonReport.Image = global::AssetControl.Properties.Resources.asset_report_32;
            this.tsButtonReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonReport.Name = "tsButtonReport";
            this.tsButtonReport.Size = new System.Drawing.Size(65, 51);
            this.tsButtonReport.Text = "Reporte";
            this.tsButtonReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonReport.Visible = false;
            this.tsButtonReport.Click += new System.EventHandler(this.tsButtonReport_Click);
            // 
            // tsSeparator6
            // 
            this.tsSeparator6.AutoSize = false;
            this.tsSeparator6.Name = "tsSeparator6";
            this.tsSeparator6.Size = new System.Drawing.Size(6, 51);
            this.tsSeparator6.Visible = false;
            // 
            // tsButtonPassword
            // 
            this.tsButtonPassword.AutoSize = false;
            this.tsButtonPassword.Image = global::AssetControl.Properties.Resources.password_32;
            this.tsButtonPassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonPassword.Name = "tsButtonPassword";
            this.tsButtonPassword.ShowDropDownArrow = false;
            this.tsButtonPassword.Size = new System.Drawing.Size(75, 51);
            this.tsButtonPassword.Text = "Contraseña";
            this.tsButtonPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonPassword.Click += new System.EventHandler(this.tsButtonPassword_Click);
            // 
            // tsSeparator7
            // 
            this.tsSeparator7.AutoSize = false;
            this.tsSeparator7.Name = "tsSeparator7";
            this.tsSeparator7.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonUsers
            // 
            this.tsButtonUsers.AutoSize = false;
            this.tsButtonUsers.Image = global::AssetControl.Properties.Resources.Users_32;
            this.tsButtonUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonUsers.Name = "tsButtonUsers";
            this.tsButtonUsers.Size = new System.Drawing.Size(65, 51);
            this.tsButtonUsers.Text = "Usuarios";
            this.tsButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonUsers.Click += new System.EventHandler(this.tsButtonUsers_Click);
            // 
            // tsSeparator8
            // 
            this.tsSeparator8.AutoSize = false;
            this.tsSeparator8.Name = "tsSeparator8";
            this.tsSeparator8.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonAudit
            // 
            this.tsButtonAudit.AutoSize = false;
            this.tsButtonAudit.Image = global::AssetControl.Properties.Resources.audit_32;
            this.tsButtonAudit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAudit.Name = "tsButtonAudit";
            this.tsButtonAudit.Size = new System.Drawing.Size(65, 51);
            this.tsButtonAudit.Text = "Logs";
            this.tsButtonAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAudit.Visible = false;
            this.tsButtonAudit.Click += new System.EventHandler(this.tsButtonAudit_Click);
            // 
            // tsSeparator9
            // 
            this.tsSeparator9.AutoSize = false;
            this.tsSeparator9.Name = "tsSeparator9";
            this.tsSeparator9.Size = new System.Drawing.Size(6, 51);
            this.tsSeparator9.Visible = false;
            // 
            // tsButtonAbout
            // 
            this.tsButtonAbout.AutoSize = false;
            this.tsButtonAbout.Image = global::AssetControl.Properties.Resources.about_32;
            this.tsButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAbout.Name = "tsButtonAbout";
            this.tsButtonAbout.Size = new System.Drawing.Size(65, 51);
            this.tsButtonAbout.Text = "About";
            this.tsButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAbout.Click += new System.EventHandler(this.tsButtonAbout_Click);
            // 
            // tsSeparator10
            // 
            this.tsSeparator10.AutoSize = false;
            this.tsSeparator10.Name = "tsSeparator10";
            this.tsSeparator10.Size = new System.Drawing.Size(6, 51);
            // 
            // tsButtonExit
            // 
            this.tsButtonExit.AutoSize = false;
            this.tsButtonExit.Image = global::AssetControl.Properties.Resources.exit_32;
            this.tsButtonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonExit.Name = "tsButtonExit";
            this.tsButtonExit.Size = new System.Drawing.Size(65, 51);
            this.tsButtonExit.Text = "Salir";
            this.tsButtonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonExit.Click += new System.EventHandler(this.tsButtonExit_Click);
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.activosToolStripMenuItem.Text = "Activos";
            // 
            // tiposDeActivosToolStripMenuItem
            // 
            this.tiposDeActivosToolStripMenuItem.Name = "tiposDeActivosToolStripMenuItem";
            this.tiposDeActivosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tiposDeActivosToolStripMenuItem.Text = "Tipos de activos";
            // 
            // estadosDeActivosToolStripMenuItem
            // 
            this.estadosDeActivosToolStripMenuItem.Name = "estadosDeActivosToolStripMenuItem";
            this.estadosDeActivosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.estadosDeActivosToolStripMenuItem.Text = "Estados de activos";
            // 
            // motivosDeSalidaToolStripMenuItem
            // 
            this.motivosDeSalidaToolStripMenuItem.Name = "motivosDeSalidaToolStripMenuItem";
            this.motivosDeSalidaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.motivosDeSalidaToolStripMenuItem.Text = "Motivos de salida";
            // 
            // lblUserMain
            // 
            this.lblUserMain.AutoSize = true;
            this.lblUserMain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMain.Location = new System.Drawing.Point(1, 55);
            this.lblUserMain.Name = "lblUserMain";
            this.lblUserMain.Size = new System.Drawing.Size(70, 15);
            this.lblUserMain.TabIndex = 5;
            this.lblUserMain.Text = "Usuario: ";
            // 
            // lblRoleMain
            // 
            this.lblRoleMain.AutoSize = true;
            this.lblRoleMain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleMain.Location = new System.Drawing.Point(335, 55);
            this.lblRoleMain.Name = "lblRoleMain";
            this.lblRoleMain.Size = new System.Drawing.Size(63, 15);
            this.lblRoleMain.TabIndex = 6;
            this.lblRoleMain.Text = "Perfil: ";
            // 
            // btnSettingsMain
            // 
            this.btnSettingsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettingsMain.FlatAppearance.BorderSize = 0;
            this.btnSettingsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsMain.Image = global::AssetControl.Properties.Resources.settings_16;
            this.btnSettingsMain.Location = new System.Drawing.Point(1060, 52);
            this.btnSettingsMain.Name = "btnSettingsMain";
            this.btnSettingsMain.Size = new System.Drawing.Size(20, 20);
            this.btnSettingsMain.TabIndex = 8;
            this.btnSettingsMain.UseVisualStyleBackColor = true;
            this.btnSettingsMain.Click += new System.EventHandler(this.btnSettingsMain_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 610);
            this.Controls.Add(this.btnSettingsMain);
            this.Controls.Add(this.lblRoleMain);
            this.Controls.Add(this.lblUserMain);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Activos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motivosDeSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonAssetType;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripButton tsButtonReport;
        private System.Windows.Forms.ToolStripSeparator tsSeparator7;
        private System.Windows.Forms.ToolStripButton tsButtonAbout;
        private System.Windows.Forms.ToolStripSeparator tsSeparator6;
        private System.Windows.Forms.ToolStripButton tsButtonExit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator10;
        private System.Windows.Forms.ToolStripLabel tsLabel;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonLocations;
        private System.Windows.Forms.ToolStripSeparator tsSeparator5;
        private System.Windows.Forms.ToolStripButton tsButtonBranches;
        private System.Windows.Forms.ToolStripSeparator tsSeparator4;
        private System.Windows.Forms.ToolStripSeparator tsSeparator8;
        private System.Windows.Forms.ToolStripButton tsButtonUsers;
        private System.Windows.Forms.ToolStripButton tsButtonAssets;
        private System.Windows.Forms.Label lblUserMain;
        private System.Windows.Forms.Label lblRoleMain;
        private System.Windows.Forms.Button btnSettingsMain;
        private System.Windows.Forms.ToolStripButton tsButtonAudit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator9;
        private System.Windows.Forms.ToolStripDropDownButton tsButtonPassword;
    }
}