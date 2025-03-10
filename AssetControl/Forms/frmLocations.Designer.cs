namespace AssetControl.Forms
{
    partial class frmLocations
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
            this.btnSearchLocations = new System.Windows.Forms.Button();
            this.txtLocationDescription = new System.Windows.Forms.TextBox();
            this.lblLocationDescription = new System.Windows.Forms.Label();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.tsLocations = new System.Windows.Forms.ToolStrip();
            this.tsButtonLocationNew = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonLocationEdit = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonLocationEndate = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgLocation = new System.Windows.Forms.DataGridView();
            this.assetLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFilterSection.SuspendLayout();
            this.pnlDataSection.SuspendLayout();
            this.tsLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.Controls.Add(this.tsLocations);
            this.pnlFilterSection.Controls.Add(this.btnSearchLocations);
            this.pnlFilterSection.Controls.Add(this.txtLocationDescription);
            this.pnlFilterSection.Controls.Add(this.lblLocationDescription);
            this.pnlFilterSection.Controls.Add(this.chkActiveOnly);
            // 
            // pnlDataSection
            // 
            this.pnlDataSection.Controls.Add(this.dtgLocation);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(401, 9);
            this.lblTitle.Size = new System.Drawing.Size(274, 24);
            this.lblTitle.Text = "Ubicaciones de Activos";
            // 
            // btnSearchLocations
            // 
            this.btnSearchLocations.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLocations.Location = new System.Drawing.Point(306, 2);
            this.btnSearchLocations.Name = "btnSearchLocations";
            this.btnSearchLocations.Size = new System.Drawing.Size(90, 23);
            this.btnSearchLocations.TabIndex = 2;
            this.btnSearchLocations.Text = "Buscar(F3)";
            this.btnSearchLocations.UseVisualStyleBackColor = true;
            this.btnSearchLocations.Click += new System.EventHandler(this.btnSearchLocations_Click);
            // 
            // txtLocationDescription
            // 
            this.txtLocationDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationDescription.Location = new System.Drawing.Point(100, 2);
            this.txtLocationDescription.MaxLength = 200;
            this.txtLocationDescription.Name = "txtLocationDescription";
            this.txtLocationDescription.Size = new System.Drawing.Size(200, 23);
            this.txtLocationDescription.TabIndex = 1;
            // 
            // lblLocationDescription
            // 
            this.lblLocationDescription.AutoSize = true;
            this.lblLocationDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDescription.Location = new System.Drawing.Point(3, 10);
            this.lblLocationDescription.Name = "lblLocationDescription";
            this.lblLocationDescription.Size = new System.Drawing.Size(91, 15);
            this.lblLocationDescription.TabIndex = 10;
            this.lblLocationDescription.Text = "Descripción:";
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Checked = true;
            this.chkActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveOnly.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiveOnly.Location = new System.Drawing.Point(402, 6);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(152, 19);
            this.chkActiveOnly.TabIndex = 11;
            this.chkActiveOnly.Text = "Sólo tipos activos";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // tsLocations
            // 
            this.tsLocations.AutoSize = false;
            this.tsLocations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsLocations.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLocations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonLocationNew,
            this.tsAssetTypeSeparator1,
            this.tsButtonLocationEdit,
            this.tsAssetTypeSeparator2,
            this.tsButtonLocationEndate,
            this.tsAssetTypeSeparator3});
            this.tsLocations.Location = new System.Drawing.Point(0, 83);
            this.tsLocations.Name = "tsLocations";
            this.tsLocations.Size = new System.Drawing.Size(1052, 36);
            this.tsLocations.TabIndex = 12;
            this.tsLocations.Text = "toolStrip1";
            // 
            // tsButtonLocationNew
            // 
            this.tsButtonLocationNew.AutoSize = false;
            this.tsButtonLocationNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonLocationNew.Image = global::AssetControl.Properties.Resources.new_32;
            this.tsButtonLocationNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonLocationNew.Name = "tsButtonLocationNew";
            this.tsButtonLocationNew.Size = new System.Drawing.Size(51, 36);
            this.tsButtonLocationNew.Text = "Nuevo";
            this.tsButtonLocationNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonLocationNew.Click += new System.EventHandler(this.tsButtonLocationNew_Click);
            // 
            // tsAssetTypeSeparator1
            // 
            this.tsAssetTypeSeparator1.Name = "tsAssetTypeSeparator1";
            this.tsAssetTypeSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonLocationEdit
            // 
            this.tsButtonLocationEdit.AutoSize = false;
            this.tsButtonLocationEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonLocationEdit.Image = global::AssetControl.Properties.Resources.edit_32;
            this.tsButtonLocationEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonLocationEdit.Name = "tsButtonLocationEdit";
            this.tsButtonLocationEdit.Size = new System.Drawing.Size(51, 36);
            this.tsButtonLocationEdit.Text = "Editar";
            this.tsButtonLocationEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonLocationEdit.Click += new System.EventHandler(this.tsButtonLocationEdit_Click);
            // 
            // tsAssetTypeSeparator2
            // 
            this.tsAssetTypeSeparator2.Name = "tsAssetTypeSeparator2";
            this.tsAssetTypeSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonLocationEndate
            // 
            this.tsButtonLocationEndate.AutoSize = false;
            this.tsButtonLocationEndate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonLocationEndate.Image = global::AssetControl.Properties.Resources.toggle_32;
            this.tsButtonLocationEndate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonLocationEndate.Name = "tsButtonLocationEndate";
            this.tsButtonLocationEndate.Size = new System.Drawing.Size(70, 36);
            this.tsButtonLocationEndate.Text = "Finalizar";
            this.tsButtonLocationEndate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonLocationEndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonLocationEndate.Click += new System.EventHandler(this.tsButtonLocationEndate_Click);
            // 
            // tsAssetTypeSeparator3
            // 
            this.tsAssetTypeSeparator3.Name = "tsAssetTypeSeparator3";
            this.tsAssetTypeSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // dtgLocation
            // 
            this.dtgLocation.AllowUserToAddRows = false;
            this.dtgLocation.AllowUserToDeleteRows = false;
            this.dtgLocation.AutoGenerateColumns = false;
            this.dtgLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetLocationId,
            this.locationDescription,
            this.endDate});
            this.dtgLocation.DataSource = this.locationBindingSource;
            this.dtgLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLocation.Location = new System.Drawing.Point(0, 0);
            this.dtgLocation.MultiSelect = false;
            this.dtgLocation.Name = "dtgLocation";
            this.dtgLocation.ReadOnly = true;
            this.dtgLocation.RowHeadersVisible = false;
            this.dtgLocation.RowHeadersWidth = 20;
            this.dtgLocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgLocation.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLocation.Size = new System.Drawing.Size(1052, 357);
            this.dtgLocation.TabIndex = 1;
            // 
            // assetLocationId
            // 
            this.assetLocationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.assetLocationId.DataPropertyName = "AssetLocationId";
            this.assetLocationId.DividerWidth = 1;
            this.assetLocationId.HeaderText = "ID";
            this.assetLocationId.Name = "assetLocationId";
            this.assetLocationId.ReadOnly = true;
            this.assetLocationId.Width = 50;
            // 
            // locationDescription
            // 
            this.locationDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.locationDescription.DataPropertyName = "LocationDescription";
            this.locationDescription.DividerWidth = 1;
            this.locationDescription.HeaderText = "Descripción";
            this.locationDescription.Name = "locationDescription";
            this.locationDescription.ReadOnly = true;
            this.locationDescription.Width = 350;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endDate.DataPropertyName = "EndDate";
            this.endDate.DividerWidth = 1;
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 150;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(AssetControl.Classes.AssetLocation);
            // 
            // frmLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.Name = "frmLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLocations";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLocations_KeyDown);
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterSection.PerformLayout();
            this.pnlDataSection.ResumeLayout(false);
            this.tsLocations.ResumeLayout(false);
            this.tsLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchLocations;
        private System.Windows.Forms.TextBox txtLocationDescription;
        private System.Windows.Forms.Label lblLocationDescription;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.ToolStrip tsLocations;
        private System.Windows.Forms.ToolStripButton tsButtonLocationNew;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonLocationEdit;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonLocationEndate;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator3;
        private System.Windows.Forms.DataGridView dtgLocation;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
    }
}