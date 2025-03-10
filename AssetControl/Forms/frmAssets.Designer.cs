namespace AssetControl.Forms
{
    partial class frmAssets
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
            this.btnSearchAssets = new System.Windows.Forms.Button();
            this.txtAssetDescription = new System.Windows.Forms.TextBox();
            this.lblAssetDescription = new System.Windows.Forms.Label();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.tsAssets = new System.Windows.Forms.ToolStrip();
            this.tsButtonNewAsset = new System.Windows.Forms.ToolStripButton();
            this.tsAssetSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonEditAsset = new System.Windows.Forms.ToolStripButton();
            this.tsAssetSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonChangeState = new System.Windows.Forms.ToolStripButton();
            this.tsAssetSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonEndate = new System.Windows.Forms.ToolStripButton();
            this.tsAssetSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonMoveAsset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbAssetType = new System.Windows.Forms.ComboBox();
            this.lblAssetType = new System.Windows.Forms.Label();
            this.chkGenericAsset = new System.Windows.Forms.CheckBox();
            this.cbAssetStatus = new System.Windows.Forms.ComboBox();
            this.lblAssetStatus = new System.Windows.Forms.Label();
            this.cbAssetLocation = new System.Windows.Forms.ComboBox();
            this.lblAssetLocation = new System.Windows.Forms.Label();
            this.cbAssetBranch = new System.Windows.Forms.ComboBox();
            this.lblAssetBranch = new System.Windows.Forms.Label();
            this.btnClearAssets = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dtgAssets = new System.Windows.Forms.DataGridView();
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericAsset = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retirementReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retirementReasonDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endateNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilterSection.SuspendLayout();
            this.pnlDataSection.SuspendLayout();
            this.tsAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.Controls.Add(this.btnClearAssets);
            this.pnlFilterSection.Controls.Add(this.cbAssetBranch);
            this.pnlFilterSection.Controls.Add(this.lblAssetBranch);
            this.pnlFilterSection.Controls.Add(this.cbAssetLocation);
            this.pnlFilterSection.Controls.Add(this.lblAssetLocation);
            this.pnlFilterSection.Controls.Add(this.cbAssetStatus);
            this.pnlFilterSection.Controls.Add(this.lblAssetStatus);
            this.pnlFilterSection.Controls.Add(this.chkGenericAsset);
            this.pnlFilterSection.Controls.Add(this.cbAssetType);
            this.pnlFilterSection.Controls.Add(this.lblAssetType);
            this.pnlFilterSection.Controls.Add(this.tsAssets);
            this.pnlFilterSection.Controls.Add(this.txtAssetTag);
            this.pnlFilterSection.Controls.Add(this.lblAssetTag);
            this.pnlFilterSection.Controls.Add(this.btnSearchAssets);
            this.pnlFilterSection.Controls.Add(this.txtAssetDescription);
            this.pnlFilterSection.Controls.Add(this.lblAssetDescription);
            this.pnlFilterSection.Controls.Add(this.chkActiveOnly);
            // 
            // pnlDataSection
            // 
            this.pnlDataSection.Controls.Add(this.dtgAssets);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(389, 9);
            this.lblTitle.Size = new System.Drawing.Size(298, 24);
            this.lblTitle.Text = "Mantenimiento de Activos";
            // 
            // btnSearchAssets
            // 
            this.btnSearchAssets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAssets.Location = new System.Drawing.Point(671, 5);
            this.btnSearchAssets.Name = "btnSearchAssets";
            this.btnSearchAssets.Size = new System.Drawing.Size(90, 23);
            this.btnSearchAssets.TabIndex = 7;
            this.btnSearchAssets.Text = "Buscar(F3)";
            this.btnSearchAssets.UseVisualStyleBackColor = true;
            this.btnSearchAssets.Click += new System.EventHandler(this.btnSearchAssets_Click);
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetDescription.Location = new System.Drawing.Point(100, 2);
            this.txtAssetDescription.MaxLength = 200;
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(200, 23);
            this.txtAssetDescription.TabIndex = 1;
            // 
            // lblAssetDescription
            // 
            this.lblAssetDescription.AutoSize = true;
            this.lblAssetDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetDescription.Location = new System.Drawing.Point(3, 10);
            this.lblAssetDescription.Name = "lblAssetDescription";
            this.lblAssetDescription.Size = new System.Drawing.Size(91, 15);
            this.lblAssetDescription.TabIndex = 20;
            this.lblAssetDescription.Text = "Descripción:";
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Checked = true;
            this.chkActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveOnly.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiveOnly.Location = new System.Drawing.Point(767, 9);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(173, 19);
            this.chkActiveOnly.TabIndex = 15;
            this.chkActiveOnly.Text = "Activos sin finalizar";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTag.Location = new System.Drawing.Point(100, 27);
            this.txtAssetTag.MaxLength = 200;
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(200, 23);
            this.txtAssetTag.TabIndex = 2;
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.AutoSize = true;
            this.lblAssetTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTag.Location = new System.Drawing.Point(3, 35);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(63, 15);
            this.lblAssetTag.TabIndex = 21;
            this.lblAssetTag.Text = "Placa #:";
            // 
            // tsAssets
            // 
            this.tsAssets.AutoSize = false;
            this.tsAssets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsAssets.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonNewAsset,
            this.tsAssetSeparator1,
            this.tsButtonEditAsset,
            this.tsAssetSeparator2,
            this.tsButtonChangeState,
            this.tsAssetSeparator3,
            this.tsButtonEndate,
            this.tsAssetSeparator4,
            this.tsButtonMoveAsset,
            this.toolStripSeparator1});
            this.tsAssets.Location = new System.Drawing.Point(0, 83);
            this.tsAssets.Name = "tsAssets";
            this.tsAssets.Size = new System.Drawing.Size(1052, 36);
            this.tsAssets.TabIndex = 18;
            this.tsAssets.Text = "toolStrip1";
            // 
            // tsButtonNewAsset
            // 
            this.tsButtonNewAsset.AutoSize = false;
            this.tsButtonNewAsset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonNewAsset.Image = global::AssetControl.Properties.Resources.new_32;
            this.tsButtonNewAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonNewAsset.Name = "tsButtonNewAsset";
            this.tsButtonNewAsset.Size = new System.Drawing.Size(51, 36);
            this.tsButtonNewAsset.Text = "Nuevo";
            this.tsButtonNewAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonNewAsset.Click += new System.EventHandler(this.tsButtonNewAsset_Click);
            // 
            // tsAssetSeparator1
            // 
            this.tsAssetSeparator1.Name = "tsAssetSeparator1";
            this.tsAssetSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonEditAsset
            // 
            this.tsButtonEditAsset.AutoSize = false;
            this.tsButtonEditAsset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonEditAsset.Image = global::AssetControl.Properties.Resources.edit_32;
            this.tsButtonEditAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonEditAsset.Name = "tsButtonEditAsset";
            this.tsButtonEditAsset.Size = new System.Drawing.Size(51, 36);
            this.tsButtonEditAsset.Text = "Editar";
            this.tsButtonEditAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonEditAsset.Click += new System.EventHandler(this.tsButtonEditAsset_Click);
            // 
            // tsAssetSeparator2
            // 
            this.tsAssetSeparator2.Name = "tsAssetSeparator2";
            this.tsAssetSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonChangeState
            // 
            this.tsButtonChangeState.AutoSize = false;
            this.tsButtonChangeState.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonChangeState.Image = global::AssetControl.Properties.Resources.arrows_32;
            this.tsButtonChangeState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonChangeState.Name = "tsButtonChangeState";
            this.tsButtonChangeState.Size = new System.Drawing.Size(51, 36);
            this.tsButtonChangeState.Text = "Estado";
            this.tsButtonChangeState.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonChangeState.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonChangeState.ToolTipText = "Estado";
            this.tsButtonChangeState.Click += new System.EventHandler(this.tsButtonChangeState_Click);
            // 
            // tsAssetSeparator3
            // 
            this.tsAssetSeparator3.Name = "tsAssetSeparator3";
            this.tsAssetSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonEndate
            // 
            this.tsButtonEndate.AutoSize = false;
            this.tsButtonEndate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonEndate.Image = global::AssetControl.Properties.Resources.toggle_32;
            this.tsButtonEndate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonEndate.Name = "tsButtonEndate";
            this.tsButtonEndate.Size = new System.Drawing.Size(58, 36);
            this.tsButtonEndate.Text = "Retirar";
            this.tsButtonEndate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonEndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonEndate.Click += new System.EventHandler(this.tsButtonEndate_Click);
            // 
            // tsAssetSeparator4
            // 
            this.tsAssetSeparator4.Name = "tsAssetSeparator4";
            this.tsAssetSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonMoveAsset
            // 
            this.tsButtonMoveAsset.AutoSize = false;
            this.tsButtonMoveAsset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonMoveAsset.Image = global::AssetControl.Properties.Resources.move_32;
            this.tsButtonMoveAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonMoveAsset.Name = "tsButtonMoveAsset";
            this.tsButtonMoveAsset.Size = new System.Drawing.Size(58, 36);
            this.tsButtonMoveAsset.Text = "Filial";
            this.tsButtonMoveAsset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonMoveAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonMoveAsset.Click += new System.EventHandler(this.tsButtonMoveAsset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // cbAssetType
            // 
            this.cbAssetType.DisplayMember = "TypeDescription";
            this.cbAssetType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetType.FormattingEnabled = true;
            this.cbAssetType.Location = new System.Drawing.Point(100, 52);
            this.cbAssetType.Name = "cbAssetType";
            this.cbAssetType.Size = new System.Drawing.Size(200, 23);
            this.cbAssetType.TabIndex = 3;
            this.cbAssetType.ValueMember = "AssetTypeid";
            this.cbAssetType.DropDown += new System.EventHandler(this.cbAssetType_DropDown);
            // 
            // lblAssetType
            // 
            this.lblAssetType.AutoSize = true;
            this.lblAssetType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetType.Location = new System.Drawing.Point(3, 60);
            this.lblAssetType.Name = "lblAssetType";
            this.lblAssetType.Size = new System.Drawing.Size(91, 15);
            this.lblAssetType.TabIndex = 22;
            this.lblAssetType.Text = "Tipo Activo:";
            // 
            // chkGenericAsset
            // 
            this.chkGenericAsset.AutoSize = true;
            this.chkGenericAsset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenericAsset.Location = new System.Drawing.Point(767, 29);
            this.chkGenericAsset.Name = "chkGenericAsset";
            this.chkGenericAsset.Size = new System.Drawing.Size(145, 19);
            this.chkGenericAsset.TabIndex = 16;
            this.chkGenericAsset.Text = "Activos genéricos";
            this.chkGenericAsset.UseVisualStyleBackColor = true;
            this.chkGenericAsset.CheckedChanged += new System.EventHandler(this.chkGenericAsset_CheckedChanged);
            // 
            // cbAssetStatus
            // 
            this.cbAssetStatus.DisplayMember = "StatusDescription";
            this.cbAssetStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetStatus.FormattingEnabled = true;
            this.cbAssetStatus.Location = new System.Drawing.Point(430, 2);
            this.cbAssetStatus.Name = "cbAssetStatus";
            this.cbAssetStatus.Size = new System.Drawing.Size(200, 23);
            this.cbAssetStatus.TabIndex = 4;
            this.cbAssetStatus.ValueMember = "Status";
            this.cbAssetStatus.DropDown += new System.EventHandler(this.cbAssetStatus_DropDown);
            // 
            // lblAssetStatus
            // 
            this.lblAssetStatus.AutoSize = true;
            this.lblAssetStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetStatus.Location = new System.Drawing.Point(333, 10);
            this.lblAssetStatus.Name = "lblAssetStatus";
            this.lblAssetStatus.Size = new System.Drawing.Size(56, 15);
            this.lblAssetStatus.TabIndex = 23;
            this.lblAssetStatus.Text = "Estado:";
            // 
            // cbAssetLocation
            // 
            this.cbAssetLocation.DisplayMember = "LocationDescription";
            this.cbAssetLocation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetLocation.FormattingEnabled = true;
            this.cbAssetLocation.Location = new System.Drawing.Point(430, 27);
            this.cbAssetLocation.Name = "cbAssetLocation";
            this.cbAssetLocation.Size = new System.Drawing.Size(200, 23);
            this.cbAssetLocation.TabIndex = 5;
            this.cbAssetLocation.ValueMember = "AssetLocationId";
            this.cbAssetLocation.DropDown += new System.EventHandler(this.cbAssetLocation_DropDown);
            // 
            // lblAssetLocation
            // 
            this.lblAssetLocation.AutoSize = true;
            this.lblAssetLocation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetLocation.Location = new System.Drawing.Point(333, 35);
            this.lblAssetLocation.Name = "lblAssetLocation";
            this.lblAssetLocation.Size = new System.Drawing.Size(77, 15);
            this.lblAssetLocation.TabIndex = 24;
            this.lblAssetLocation.Text = "Ubicación:";
            // 
            // cbAssetBranch
            // 
            this.cbAssetBranch.DisplayMember = "BranchDescription";
            this.cbAssetBranch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetBranch.FormattingEnabled = true;
            this.cbAssetBranch.Location = new System.Drawing.Point(430, 52);
            this.cbAssetBranch.Name = "cbAssetBranch";
            this.cbAssetBranch.Size = new System.Drawing.Size(200, 23);
            this.cbAssetBranch.TabIndex = 6;
            this.cbAssetBranch.ValueMember = "BranchId";
            this.cbAssetBranch.DropDown += new System.EventHandler(this.cbAssetBranch_DropDown);
            // 
            // lblAssetBranch
            // 
            this.lblAssetBranch.AutoSize = true;
            this.lblAssetBranch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetBranch.Location = new System.Drawing.Point(333, 60);
            this.lblAssetBranch.Name = "lblAssetBranch";
            this.lblAssetBranch.Size = new System.Drawing.Size(56, 15);
            this.lblAssetBranch.TabIndex = 25;
            this.lblAssetBranch.Text = "Filial:";
            // 
            // btnClearAssets
            // 
            this.btnClearAssets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAssets.Location = new System.Drawing.Point(671, 34);
            this.btnClearAssets.Name = "btnClearAssets";
            this.btnClearAssets.Size = new System.Drawing.Size(90, 23);
            this.btnClearAssets.TabIndex = 28;
            this.btnClearAssets.Text = "Limpiar(F5)";
            this.btnClearAssets.UseVisualStyleBackColor = true;
            this.btnClearAssets.Click += new System.EventHandler(this.btnClearAssets_Click);
            // 
            // dtgAssets
            // 
            this.dtgAssets.AllowUserToAddRows = false;
            this.dtgAssets.AllowUserToDeleteRows = false;
            this.dtgAssets.AllowUserToOrderColumns = true;
            this.dtgAssets.AutoGenerateColumns = false;
            this.dtgAssets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgAssets.ColumnHeadersHeight = 21;
            this.dtgAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.description,
            this.assetType,
            this.assetTypeDescription,
            this.status,
            this.statusDescription,
            this.assetTagDataGridViewTextBoxColumn,
            this.location,
            this.locationDescription,
            this.branch,
            this.branchDescription,
            this.price,
            this.observations,
            this.serialNumber,
            this.genericAsset,
            this.quantity,
            this.purchaseDate,
            this.warrantyMonths,
            this.endDate,
            this.retirementReason,
            this.retirementReasonDescription,
            this.endateNote});
            this.dtgAssets.DataSource = this.assetBindingSource;
            this.dtgAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAssets.Location = new System.Drawing.Point(0, 0);
            this.dtgAssets.MultiSelect = false;
            this.dtgAssets.Name = "dtgAssets";
            this.dtgAssets.ReadOnly = true;
            this.dtgAssets.RowHeadersVisible = false;
            this.dtgAssets.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgAssets.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAssets.Size = new System.Drawing.Size(1052, 357);
            this.dtgAssets.TabIndex = 1;
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataSource = typeof(AssetControl.Classes.Asset);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "Id";
            this.id.DividerWidth = 1;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.description.DataPropertyName = "Description";
            this.description.DividerWidth = 1;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 200;
            // 
            // assetType
            // 
            this.assetType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.assetType.DataPropertyName = "AssetType";
            this.assetType.DividerWidth = 1;
            this.assetType.HeaderText = "Tipo Activo";
            this.assetType.Name = "assetType";
            this.assetType.ReadOnly = true;
            this.assetType.Visible = false;
            this.assetType.Width = 150;
            // 
            // assetTypeDescription
            // 
            this.assetTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.assetTypeDescription.DataPropertyName = "AssetTypeDescription";
            this.assetTypeDescription.DividerWidth = 1;
            this.assetTypeDescription.HeaderText = "Tipo de Activo";
            this.assetTypeDescription.Name = "assetTypeDescription";
            this.assetTypeDescription.ReadOnly = true;
            this.assetTypeDescription.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.DataPropertyName = "Status";
            this.status.DividerWidth = 1;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            this.status.Width = 50;
            // 
            // statusDescription
            // 
            this.statusDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusDescription.DataPropertyName = "StatusDescription";
            this.statusDescription.DividerWidth = 1;
            this.statusDescription.HeaderText = "Estado";
            this.statusDescription.Name = "statusDescription";
            this.statusDescription.ReadOnly = true;
            this.statusDescription.Width = 150;
            // 
            // assetTagDataGridViewTextBoxColumn
            // 
            this.assetTagDataGridViewTextBoxColumn.DataPropertyName = "AssetTag";
            this.assetTagDataGridViewTextBoxColumn.DividerWidth = 1;
            this.assetTagDataGridViewTextBoxColumn.HeaderText = "# Placa";
            this.assetTagDataGridViewTextBoxColumn.Name = "assetTagDataGridViewTextBoxColumn";
            this.assetTagDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetTagDataGridViewTextBoxColumn.Width = 125;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.location.DataPropertyName = "Location";
            this.location.DividerWidth = 1;
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Visible = false;
            this.location.Width = 50;
            // 
            // locationDescription
            // 
            this.locationDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.locationDescription.DataPropertyName = "LocationDescription";
            this.locationDescription.DividerWidth = 1;
            this.locationDescription.HeaderText = "Ubicación";
            this.locationDescription.Name = "locationDescription";
            this.locationDescription.ReadOnly = true;
            this.locationDescription.Width = 150;
            // 
            // branch
            // 
            this.branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.branch.DataPropertyName = "Branch";
            this.branch.DividerWidth = 1;
            this.branch.HeaderText = "Branch";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            this.branch.Visible = false;
            this.branch.Width = 50;
            // 
            // branchDescription
            // 
            this.branchDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.branchDescription.DataPropertyName = "BranchDescription";
            this.branchDescription.DividerWidth = 1;
            this.branchDescription.HeaderText = "Filial";
            this.branchDescription.Name = "branchDescription";
            this.branchDescription.ReadOnly = true;
            this.branchDescription.Width = 150;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.DataPropertyName = "Price";
            this.price.DividerWidth = 1;
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // observations
            // 
            this.observations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.observations.DataPropertyName = "Observations";
            this.observations.DividerWidth = 1;
            this.observations.HeaderText = "Observaciones";
            this.observations.Name = "observations";
            this.observations.ReadOnly = true;
            this.observations.Width = 200;
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serialNumber.DataPropertyName = "SerialNumber";
            this.serialNumber.DividerWidth = 1;
            this.serialNumber.HeaderText = "# Serie";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            this.serialNumber.Width = 150;
            // 
            // genericAsset
            // 
            this.genericAsset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.genericAsset.DataPropertyName = "GenericAsset";
            this.genericAsset.DividerWidth = 1;
            this.genericAsset.HeaderText = "Genérico";
            this.genericAsset.Name = "genericAsset";
            this.genericAsset.ReadOnly = true;
            this.genericAsset.Width = 75;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.DividerWidth = 1;
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 75;
            // 
            // purchaseDate
            // 
            this.purchaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchaseDate.DataPropertyName = "PurchaseDate";
            this.purchaseDate.DividerWidth = 1;
            this.purchaseDate.HeaderText = "Fecha compra";
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.ReadOnly = true;
            // 
            // warrantyMonths
            // 
            this.warrantyMonths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.warrantyMonths.DataPropertyName = "WarrantyMonths";
            this.warrantyMonths.DividerWidth = 1;
            this.warrantyMonths.HeaderText = "Garantía";
            this.warrantyMonths.Name = "warrantyMonths";
            this.warrantyMonths.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endDate.DataPropertyName = "EndDate";
            this.endDate.DividerWidth = 1;
            this.endDate.HeaderText = "Fecha retiro";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 150;
            // 
            // retirementReason
            // 
            this.retirementReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retirementReason.DataPropertyName = "RetirementReason";
            this.retirementReason.DividerWidth = 1;
            this.retirementReason.HeaderText = "RetirementReason";
            this.retirementReason.Name = "retirementReason";
            this.retirementReason.ReadOnly = true;
            this.retirementReason.Visible = false;
            // 
            // retirementReasonDescription
            // 
            this.retirementReasonDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retirementReasonDescription.DataPropertyName = "RetirementReasonDescription";
            this.retirementReasonDescription.DividerWidth = 1;
            this.retirementReasonDescription.HeaderText = "Motivo retiro";
            this.retirementReasonDescription.Name = "retirementReasonDescription";
            this.retirementReasonDescription.ReadOnly = true;
            this.retirementReasonDescription.Width = 125;
            // 
            // endateNote
            // 
            this.endateNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endateNote.DataPropertyName = "EndateNote";
            this.endateNote.DividerWidth = 1;
            this.endateNote.HeaderText = "Nota Retiro";
            this.endateNote.Name = "endateNote";
            this.endateNote.ReadOnly = true;
            this.endateNote.Width = 300;
            // 
            // frmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.Name = "frmAssets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAssets";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAssets_KeyDown);
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterSection.PerformLayout();
            this.pnlDataSection.ResumeLayout(false);
            this.tsAssets.ResumeLayout(false);
            this.tsAssets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchAssets;
        private System.Windows.Forms.TextBox txtAssetDescription;
        private System.Windows.Forms.Label lblAssetDescription;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.ToolStrip tsAssets;
        private System.Windows.Forms.ToolStripButton tsButtonNewAsset;
        private System.Windows.Forms.ToolStripSeparator tsAssetSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonEditAsset;
        private System.Windows.Forms.ToolStripSeparator tsAssetSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonEndate;
        private System.Windows.Forms.ToolStripSeparator tsAssetSeparator3;
        private System.Windows.Forms.ToolStripButton tsButtonChangeState;
        private System.Windows.Forms.ToolStripSeparator tsAssetSeparator4;
        private System.Windows.Forms.ComboBox cbAssetType;
        private System.Windows.Forms.Label lblAssetType;
        private System.Windows.Forms.CheckBox chkGenericAsset;
        private System.Windows.Forms.ComboBox cbAssetLocation;
        private System.Windows.Forms.Label lblAssetLocation;
        private System.Windows.Forms.ComboBox cbAssetStatus;
        private System.Windows.Forms.Label lblAssetStatus;
        private System.Windows.Forms.ComboBox cbAssetBranch;
        private System.Windows.Forms.Label lblAssetBranch;
        private System.Windows.Forms.Button btnClearAssets;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dtgAssets;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private System.Windows.Forms.ToolStripButton tsButtonMoveAsset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTypeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn observations;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genericAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyMonths;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn retirementReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn retirementReasonDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn endateNote;
    }
}