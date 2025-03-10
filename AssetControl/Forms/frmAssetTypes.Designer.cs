namespace AssetControl.Forms
{
    partial class frmAssetTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsAssetTypes = new System.Windows.Forms.ToolStrip();
            this.tsButtonAssetTypeNew = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAssetTypeEdit = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAssetTypeEndate = new System.Windows.Forms.ToolStripButton();
            this.tsAssetTypeSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgAssetType = new System.Windows.Forms.DataGridView();
            this.assetTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.lblAssetTypeDescription = new System.Windows.Forms.Label();
            this.txtAssetTypeDescription = new System.Windows.Forms.TextBox();
            this.btnSearchAssetType = new System.Windows.Forms.Button();
            this.pnlFilterSection.SuspendLayout();
            this.pnlDataSection.SuspendLayout();
            this.tsAssetTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssetType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.Controls.Add(this.btnSearchAssetType);
            this.pnlFilterSection.Controls.Add(this.txtAssetTypeDescription);
            this.pnlFilterSection.Controls.Add(this.lblAssetTypeDescription);
            this.pnlFilterSection.Controls.Add(this.chkActiveOnly);
            this.pnlFilterSection.Controls.Add(this.tsAssetTypes);
            // 
            // pnlDataSection
            // 
            this.pnlDataSection.Controls.Add(this.dtgAssetType);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(437, 9);
            this.lblTitle.Size = new System.Drawing.Size(202, 24);
            this.lblTitle.Text = "Tipos de Activos";
            // 
            // tsAssetTypes
            // 
            this.tsAssetTypes.AutoSize = false;
            this.tsAssetTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsAssetTypes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAssetTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonAssetTypeNew,
            this.tsAssetTypeSeparator1,
            this.tsButtonAssetTypeEdit,
            this.tsAssetTypeSeparator2,
            this.tsButtonAssetTypeEndate,
            this.tsAssetTypeSeparator3});
            this.tsAssetTypes.Location = new System.Drawing.Point(0, 83);
            this.tsAssetTypes.Name = "tsAssetTypes";
            this.tsAssetTypes.Size = new System.Drawing.Size(1052, 36);
            this.tsAssetTypes.TabIndex = 0;
            this.tsAssetTypes.Text = "toolStrip1";
            // 
            // tsButtonAssetTypeNew
            // 
            this.tsButtonAssetTypeNew.AutoSize = false;
            this.tsButtonAssetTypeNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonAssetTypeNew.Image = global::AssetControl.Properties.Resources.new_32;
            this.tsButtonAssetTypeNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAssetTypeNew.Name = "tsButtonAssetTypeNew";
            this.tsButtonAssetTypeNew.Size = new System.Drawing.Size(51, 36);
            this.tsButtonAssetTypeNew.Text = "Nuevo";
            this.tsButtonAssetTypeNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAssetTypeNew.Click += new System.EventHandler(this.tsButtonAssetTypeNew_Click);
            // 
            // tsAssetTypeSeparator1
            // 
            this.tsAssetTypeSeparator1.Name = "tsAssetTypeSeparator1";
            this.tsAssetTypeSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonAssetTypeEdit
            // 
            this.tsButtonAssetTypeEdit.AutoSize = false;
            this.tsButtonAssetTypeEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonAssetTypeEdit.Image = global::AssetControl.Properties.Resources.edit_32;
            this.tsButtonAssetTypeEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAssetTypeEdit.Name = "tsButtonAssetTypeEdit";
            this.tsButtonAssetTypeEdit.Size = new System.Drawing.Size(51, 36);
            this.tsButtonAssetTypeEdit.Text = "Editar";
            this.tsButtonAssetTypeEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAssetTypeEdit.Click += new System.EventHandler(this.tsButtonAssetTypeEdit_Click);
            // 
            // tsAssetTypeSeparator2
            // 
            this.tsAssetTypeSeparator2.Name = "tsAssetTypeSeparator2";
            this.tsAssetTypeSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonAssetTypeEndate
            // 
            this.tsButtonAssetTypeEndate.AutoSize = false;
            this.tsButtonAssetTypeEndate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonAssetTypeEndate.Image = global::AssetControl.Properties.Resources.toggle_32;
            this.tsButtonAssetTypeEndate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAssetTypeEndate.Name = "tsButtonAssetTypeEndate";
            this.tsButtonAssetTypeEndate.Size = new System.Drawing.Size(70, 36);
            this.tsButtonAssetTypeEndate.Text = "Finalizar";
            this.tsButtonAssetTypeEndate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonAssetTypeEndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonAssetTypeEndate.Click += new System.EventHandler(this.tsAssetTypeEndate_Click);
            // 
            // tsAssetTypeSeparator3
            // 
            this.tsAssetTypeSeparator3.Name = "tsAssetTypeSeparator3";
            this.tsAssetTypeSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // dtgAssetType
            // 
            this.dtgAssetType.AllowUserToAddRows = false;
            this.dtgAssetType.AllowUserToDeleteRows = false;
            this.dtgAssetType.AutoGenerateColumns = false;
            this.dtgAssetType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgAssetType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAssetType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetTypeId,
            this.typeDescription,
            this.endDate});
            this.dtgAssetType.DataSource = this.assetTypeBindingSource;
            this.dtgAssetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAssetType.Location = new System.Drawing.Point(0, 0);
            this.dtgAssetType.MultiSelect = false;
            this.dtgAssetType.Name = "dtgAssetType";
            this.dtgAssetType.ReadOnly = true;
            this.dtgAssetType.RowHeadersVisible = false;
            this.dtgAssetType.RowHeadersWidth = 20;
            this.dtgAssetType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgAssetType.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAssetType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAssetType.Size = new System.Drawing.Size(1052, 357);
            this.dtgAssetType.TabIndex = 0;
            // 
            // assetTypeId
            // 
            this.assetTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.assetTypeId.DataPropertyName = "AssetTypeId";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTypeId.DefaultCellStyle = dataGridViewCellStyle1;
            this.assetTypeId.DividerWidth = 1;
            this.assetTypeId.HeaderText = "ID";
            this.assetTypeId.Name = "assetTypeId";
            this.assetTypeId.ReadOnly = true;
            this.assetTypeId.Width = 50;
            // 
            // typeDescription
            // 
            this.typeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDescription.DataPropertyName = "TypeDescription";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.typeDescription.DividerWidth = 1;
            this.typeDescription.FillWeight = 200F;
            this.typeDescription.HeaderText = "Descripción";
            this.typeDescription.Name = "typeDescription";
            this.typeDescription.ReadOnly = true;
            this.typeDescription.Width = 350;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.endDate.DividerWidth = 1;
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 150;
            // 
            // assetTypeBindingSource
            // 
            this.assetTypeBindingSource.DataSource = typeof(AssetControl.Classes.AssetType);
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
            this.chkActiveOnly.TabIndex = 1;
            this.chkActiveOnly.Text = "Sólo tipos activos";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // lblAssetTypeDescription
            // 
            this.lblAssetTypeDescription.AutoSize = true;
            this.lblAssetTypeDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTypeDescription.Location = new System.Drawing.Point(3, 10);
            this.lblAssetTypeDescription.Name = "lblAssetTypeDescription";
            this.lblAssetTypeDescription.Size = new System.Drawing.Size(91, 15);
            this.lblAssetTypeDescription.TabIndex = 2;
            this.lblAssetTypeDescription.Text = "Descripción:";
            // 
            // txtAssetTypeDescription
            // 
            this.txtAssetTypeDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTypeDescription.Location = new System.Drawing.Point(100, 2);
            this.txtAssetTypeDescription.MaxLength = 200;
            this.txtAssetTypeDescription.Name = "txtAssetTypeDescription";
            this.txtAssetTypeDescription.Size = new System.Drawing.Size(200, 23);
            this.txtAssetTypeDescription.TabIndex = 3;
            // 
            // btnSearchAssetType
            // 
            this.btnSearchAssetType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAssetType.Location = new System.Drawing.Point(306, 2);
            this.btnSearchAssetType.Name = "btnSearchAssetType";
            this.btnSearchAssetType.Size = new System.Drawing.Size(90, 23);
            this.btnSearchAssetType.TabIndex = 4;
            this.btnSearchAssetType.Text = "Buscar(F3)";
            this.btnSearchAssetType.UseVisualStyleBackColor = true;
            this.btnSearchAssetType.Click += new System.EventHandler(this.btnSearchAssetType_Click);
            // 
            // frmAssetTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssetTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tipos de Activos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAssetTypes_KeyDown);
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterSection.PerformLayout();
            this.pnlDataSection.ResumeLayout(false);
            this.tsAssetTypes.ResumeLayout(false);
            this.tsAssetTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssetType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAssetTypes;
        private System.Windows.Forms.ToolStripButton tsButtonAssetTypeNew;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonAssetTypeEdit;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonAssetTypeEndate;
        private System.Windows.Forms.ToolStripSeparator tsAssetTypeSeparator3;
        private System.Windows.Forms.DataGridView dtgAssetType;
        private System.Windows.Forms.BindingSource assetTypeBindingSource;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.Label lblAssetTypeDescription;
        private System.Windows.Forms.TextBox txtAssetTypeDescription;
        private System.Windows.Forms.Button btnSearchAssetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
    }
}