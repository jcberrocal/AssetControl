namespace AssetControl.Forms
{
    partial class frmAssetEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetEdit));
            this.txtAssetId = new System.Windows.Forms.TextBox();
            this.txtAssetDescription = new System.Windows.Forms.TextBox();
            this.cbAssetType = new System.Windows.Forms.ComboBox();
            this.cbAssetStatus = new System.Windows.Forms.ComboBox();
            this.cbAssetLocation = new System.Windows.Forms.ComboBox();
            this.cbAssetBranch = new System.Windows.Forms.ComboBox();
            this.txtAssetPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtAssetObservations = new System.Windows.Forms.TextBox();
            this.txtAssetSerialNumber = new System.Windows.Forms.TextBox();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.chkGenericAsset = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.dtpAssetPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtAssetWarrantyMonths = new System.Windows.Forms.MaskedTextBox();
            this.lblAssetId = new System.Windows.Forms.Label();
            this.lblAssetDescription = new System.Windows.Forms.Label();
            this.lblAssetType = new System.Windows.Forms.Label();
            this.lblAssetStatus = new System.Windows.Forms.Label();
            this.lblAssetLocation = new System.Windows.Forms.Label();
            this.lblAssetBranch = new System.Windows.Forms.Label();
            this.lblAssetPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAssetSerialNumber = new System.Windows.Forms.Label();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitleAssetEdit = new System.Windows.Forms.Label();
            this.chkRememberAssetType = new System.Windows.Forms.CheckBox();
            this.chkRememberAssetLocation = new System.Windows.Forms.CheckBox();
            this.chkRememberAssetBranch = new System.Windows.Forms.CheckBox();
            this.btnHelpAssetType = new System.Windows.Forms.Button();
            this.btnHelpAssetLocation = new System.Windows.Forms.Button();
            this.btnHelpAssetBranch = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelpGenericAsset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAssetId
            // 
            this.txtAssetId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAssetId.Enabled = false;
            this.txtAssetId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetId.Location = new System.Drawing.Point(123, 57);
            this.txtAssetId.Name = "txtAssetId";
            this.txtAssetId.Size = new System.Drawing.Size(179, 23);
            this.txtAssetId.TabIndex = 500;
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAssetDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetDescription.Location = new System.Drawing.Point(123, 86);
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(179, 23);
            this.txtAssetDescription.TabIndex = 0;
            // 
            // cbAssetType
            // 
            this.cbAssetType.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbAssetType.DisplayMember = "TypeDescription";
            this.cbAssetType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetType.FormattingEnabled = true;
            this.cbAssetType.Location = new System.Drawing.Point(123, 115);
            this.cbAssetType.Name = "cbAssetType";
            this.cbAssetType.Size = new System.Drawing.Size(179, 23);
            this.cbAssetType.TabIndex = 2;
            this.cbAssetType.ValueMember = "AssetTypeId";
            // 
            // cbAssetStatus
            // 
            this.cbAssetStatus.DisplayMember = "StatusDescription";
            this.cbAssetStatus.Enabled = false;
            this.cbAssetStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetStatus.FormattingEnabled = true;
            this.cbAssetStatus.Location = new System.Drawing.Point(123, 144);
            this.cbAssetStatus.Name = "cbAssetStatus";
            this.cbAssetStatus.Size = new System.Drawing.Size(179, 23);
            this.cbAssetStatus.TabIndex = 3;
            this.cbAssetStatus.ValueMember = "Status";
            // 
            // cbAssetLocation
            // 
            this.cbAssetLocation.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbAssetLocation.DisplayMember = "LocationDescription";
            this.cbAssetLocation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetLocation.FormattingEnabled = true;
            this.cbAssetLocation.Location = new System.Drawing.Point(123, 173);
            this.cbAssetLocation.Name = "cbAssetLocation";
            this.cbAssetLocation.Size = new System.Drawing.Size(179, 23);
            this.cbAssetLocation.TabIndex = 4;
            this.cbAssetLocation.ValueMember = "AssetLocationId";
            // 
            // cbAssetBranch
            // 
            this.cbAssetBranch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbAssetBranch.DisplayMember = "BranchDescription";
            this.cbAssetBranch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssetBranch.FormattingEnabled = true;
            this.cbAssetBranch.Location = new System.Drawing.Point(123, 202);
            this.cbAssetBranch.Name = "cbAssetBranch";
            this.cbAssetBranch.Size = new System.Drawing.Size(179, 23);
            this.cbAssetBranch.TabIndex = 5;
            this.cbAssetBranch.ValueMember = "BranchId";
            // 
            // txtAssetPrice
            // 
            this.txtAssetPrice.Location = new System.Drawing.Point(123, 231);
            this.txtAssetPrice.Mask = "$###,###";
            this.txtAssetPrice.Name = "txtAssetPrice";
            this.txtAssetPrice.Size = new System.Drawing.Size(179, 23);
            this.txtAssetPrice.TabIndex = 6;
            this.txtAssetPrice.Text = "0";
            this.txtAssetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAssetObservations
            // 
            this.txtAssetObservations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetObservations.Location = new System.Drawing.Point(123, 260);
            this.txtAssetObservations.Multiline = true;
            this.txtAssetObservations.Name = "txtAssetObservations";
            this.txtAssetObservations.Size = new System.Drawing.Size(548, 46);
            this.txtAssetObservations.TabIndex = 7;
            // 
            // txtAssetSerialNumber
            // 
            this.txtAssetSerialNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetSerialNumber.Location = new System.Drawing.Point(502, 54);
            this.txtAssetSerialNumber.Name = "txtAssetSerialNumber";
            this.txtAssetSerialNumber.Size = new System.Drawing.Size(179, 23);
            this.txtAssetSerialNumber.TabIndex = 8;
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTag.Location = new System.Drawing.Point(502, 83);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(179, 23);
            this.txtAssetTag.TabIndex = 9;
            // 
            // chkGenericAsset
            // 
            this.chkGenericAsset.AutoSize = true;
            this.chkGenericAsset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenericAsset.Location = new System.Drawing.Point(502, 112);
            this.chkGenericAsset.Name = "chkGenericAsset";
            this.chkGenericAsset.Size = new System.Drawing.Size(131, 19);
            this.chkGenericAsset.TabIndex = 10;
            this.chkGenericAsset.Text = "Activo Genérico";
            this.chkGenericAsset.UseVisualStyleBackColor = true;
            this.chkGenericAsset.CheckedChanged += new System.EventHandler(this.chkGenericAsset_CheckedChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(502, 138);
            this.txtQuantity.Mask = "99999";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(179, 23);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.Text = "1";
            this.txtQuantity.ValidatingType = typeof(int);
            // 
            // dtpAssetPurchaseDate
            // 
            this.dtpAssetPurchaseDate.Checked = false;
            this.dtpAssetPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAssetPurchaseDate.Location = new System.Drawing.Point(502, 168);
            this.dtpAssetPurchaseDate.Name = "dtpAssetPurchaseDate";
            this.dtpAssetPurchaseDate.ShowCheckBox = true;
            this.dtpAssetPurchaseDate.Size = new System.Drawing.Size(179, 23);
            this.dtpAssetPurchaseDate.TabIndex = 12;
            // 
            // txtAssetWarrantyMonths
            // 
            this.txtAssetWarrantyMonths.Location = new System.Drawing.Point(502, 197);
            this.txtAssetWarrantyMonths.Mask = "#0";
            this.txtAssetWarrantyMonths.Name = "txtAssetWarrantyMonths";
            this.txtAssetWarrantyMonths.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAssetWarrantyMonths.Size = new System.Drawing.Size(179, 23);
            this.txtAssetWarrantyMonths.TabIndex = 13;
            this.txtAssetWarrantyMonths.Text = "0";
            // 
            // lblAssetId
            // 
            this.lblAssetId.AutoSize = true;
            this.lblAssetId.Enabled = false;
            this.lblAssetId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetId.Location = new System.Drawing.Point(12, 60);
            this.lblAssetId.Name = "lblAssetId";
            this.lblAssetId.Size = new System.Drawing.Size(28, 15);
            this.lblAssetId.TabIndex = 14;
            this.lblAssetId.Text = "ID:";
            // 
            // lblAssetDescription
            // 
            this.lblAssetDescription.AutoSize = true;
            this.lblAssetDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetDescription.Location = new System.Drawing.Point(12, 89);
            this.lblAssetDescription.Name = "lblAssetDescription";
            this.lblAssetDescription.Size = new System.Drawing.Size(91, 15);
            this.lblAssetDescription.TabIndex = 15;
            this.lblAssetDescription.Text = "Descripción:";
            // 
            // lblAssetType
            // 
            this.lblAssetType.AutoSize = true;
            this.lblAssetType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetType.Location = new System.Drawing.Point(12, 118);
            this.lblAssetType.Name = "lblAssetType";
            this.lblAssetType.Size = new System.Drawing.Size(42, 15);
            this.lblAssetType.TabIndex = 16;
            this.lblAssetType.Text = "Tipo:";
            // 
            // lblAssetStatus
            // 
            this.lblAssetStatus.AutoSize = true;
            this.lblAssetStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetStatus.Location = new System.Drawing.Point(12, 147);
            this.lblAssetStatus.Name = "lblAssetStatus";
            this.lblAssetStatus.Size = new System.Drawing.Size(56, 15);
            this.lblAssetStatus.TabIndex = 17;
            this.lblAssetStatus.Text = "Estado:";
            // 
            // lblAssetLocation
            // 
            this.lblAssetLocation.AutoSize = true;
            this.lblAssetLocation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetLocation.Location = new System.Drawing.Point(12, 176);
            this.lblAssetLocation.Name = "lblAssetLocation";
            this.lblAssetLocation.Size = new System.Drawing.Size(77, 15);
            this.lblAssetLocation.TabIndex = 18;
            this.lblAssetLocation.Text = "Ubicación:";
            // 
            // lblAssetBranch
            // 
            this.lblAssetBranch.AutoSize = true;
            this.lblAssetBranch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetBranch.Location = new System.Drawing.Point(12, 205);
            this.lblAssetBranch.Name = "lblAssetBranch";
            this.lblAssetBranch.Size = new System.Drawing.Size(56, 15);
            this.lblAssetBranch.TabIndex = 19;
            this.lblAssetBranch.Text = "Filial:";
            // 
            // lblAssetPrice
            // 
            this.lblAssetPrice.AutoSize = true;
            this.lblAssetPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetPrice.Location = new System.Drawing.Point(12, 234);
            this.lblAssetPrice.Name = "lblAssetPrice";
            this.lblAssetPrice.Size = new System.Drawing.Size(56, 15);
            this.lblAssetPrice.TabIndex = 20;
            this.lblAssetPrice.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Observaciones:";
            // 
            // lblAssetSerialNumber
            // 
            this.lblAssetSerialNumber.AutoSize = true;
            this.lblAssetSerialNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetSerialNumber.Location = new System.Drawing.Point(363, 60);
            this.lblAssetSerialNumber.Name = "lblAssetSerialNumber";
            this.lblAssetSerialNumber.Size = new System.Drawing.Size(119, 15);
            this.lblAssetSerialNumber.TabIndex = 22;
            this.lblAssetSerialNumber.Text = "Número de serie:";
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.AutoSize = true;
            this.lblAssetTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTag.Location = new System.Drawing.Point(363, 89);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(119, 15);
            this.lblAssetTag.TabIndex = 23;
            this.lblAssetTag.Text = "Número de placa:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Enabled = false;
            this.lblQuantity.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(363, 147);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 15);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Meses de garantía:";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(123, 316);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(120, 23);
            this.btnSaveAndNew.TabIndex = 27;
            this.btnSaveAndNew.Text = "Guardar y Nuevo";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Visible = false;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(262, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(357, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitleAssetEdit
            // 
            this.lblTitleAssetEdit.AutoSize = true;
            this.lblTitleAssetEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAssetEdit.Location = new System.Drawing.Point(245, 15);
            this.lblTitleAssetEdit.Name = "lblTitleAssetEdit";
            this.lblTitleAssetEdit.Size = new System.Drawing.Size(154, 24);
            this.lblTitleAssetEdit.TabIndex = 30;
            this.lblTitleAssetEdit.Text = "Crear Activo";
            // 
            // chkRememberAssetType
            // 
            this.chkRememberAssetType.AutoSize = true;
            this.chkRememberAssetType.Location = new System.Drawing.Point(308, 119);
            this.chkRememberAssetType.Name = "chkRememberAssetType";
            this.chkRememberAssetType.Size = new System.Drawing.Size(15, 14);
            this.chkRememberAssetType.TabIndex = 31;
            this.toolTip.SetToolTip(this.chkRememberAssetType, "Recordar");
            this.chkRememberAssetType.UseVisualStyleBackColor = true;
            // 
            // chkRememberAssetLocation
            // 
            this.chkRememberAssetLocation.AutoSize = true;
            this.chkRememberAssetLocation.Location = new System.Drawing.Point(308, 177);
            this.chkRememberAssetLocation.Name = "chkRememberAssetLocation";
            this.chkRememberAssetLocation.Size = new System.Drawing.Size(15, 14);
            this.chkRememberAssetLocation.TabIndex = 32;
            this.toolTip.SetToolTip(this.chkRememberAssetLocation, "Recordar");
            this.chkRememberAssetLocation.UseVisualStyleBackColor = true;
            // 
            // chkRememberAssetBranch
            // 
            this.chkRememberAssetBranch.AutoSize = true;
            this.chkRememberAssetBranch.Location = new System.Drawing.Point(308, 206);
            this.chkRememberAssetBranch.Name = "chkRememberAssetBranch";
            this.chkRememberAssetBranch.Size = new System.Drawing.Size(15, 14);
            this.chkRememberAssetBranch.TabIndex = 33;
            this.toolTip.SetToolTip(this.chkRememberAssetBranch, "Recordar");
            this.chkRememberAssetBranch.UseVisualStyleBackColor = true;
            // 
            // btnHelpAssetType
            // 
            this.btnHelpAssetType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpAssetType.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpAssetType.BackgroundImage")));
            this.btnHelpAssetType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpAssetType.FlatAppearance.BorderSize = 0;
            this.btnHelpAssetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpAssetType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpAssetType.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetType.Location = new System.Drawing.Point(329, 119);
            this.btnHelpAssetType.Name = "btnHelpAssetType";
            this.btnHelpAssetType.Size = new System.Drawing.Size(16, 16);
            this.btnHelpAssetType.TabIndex = 34;
            this.btnHelpAssetType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpAssetType, "El Tipo de Activo seleccionado se\r\nmantiene para el próximo Activo");
            this.btnHelpAssetType.UseVisualStyleBackColor = false;
            // 
            // btnHelpAssetLocation
            // 
            this.btnHelpAssetLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpAssetLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpAssetLocation.BackgroundImage")));
            this.btnHelpAssetLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpAssetLocation.FlatAppearance.BorderSize = 0;
            this.btnHelpAssetLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpAssetLocation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpAssetLocation.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetLocation.Location = new System.Drawing.Point(329, 176);
            this.btnHelpAssetLocation.Name = "btnHelpAssetLocation";
            this.btnHelpAssetLocation.Size = new System.Drawing.Size(16, 16);
            this.btnHelpAssetLocation.TabIndex = 35;
            this.btnHelpAssetLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpAssetLocation, "La Ubicación seleccionada se\r\nmantiene para el próximo Activo\r\n");
            this.btnHelpAssetLocation.UseVisualStyleBackColor = false;
            // 
            // btnHelpAssetBranch
            // 
            this.btnHelpAssetBranch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpAssetBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpAssetBranch.BackgroundImage")));
            this.btnHelpAssetBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpAssetBranch.FlatAppearance.BorderSize = 0;
            this.btnHelpAssetBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpAssetBranch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpAssetBranch.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpAssetBranch.Location = new System.Drawing.Point(329, 206);
            this.btnHelpAssetBranch.Name = "btnHelpAssetBranch";
            this.btnHelpAssetBranch.Size = new System.Drawing.Size(16, 16);
            this.btnHelpAssetBranch.TabIndex = 36;
            this.btnHelpAssetBranch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpAssetBranch, "La Filial seleccionada se\r\nmantiene para el próximo Activo\r\n");
            this.btnHelpAssetBranch.UseVisualStyleBackColor = false;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 8000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // btnHelpGenericAsset
            // 
            this.btnHelpGenericAsset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpGenericAsset.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpGenericAsset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpGenericAsset.BackgroundImage")));
            this.btnHelpGenericAsset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpGenericAsset.FlatAppearance.BorderSize = 0;
            this.btnHelpGenericAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpGenericAsset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpGenericAsset.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpGenericAsset.Location = new System.Drawing.Point(639, 112);
            this.btnHelpGenericAsset.Name = "btnHelpGenericAsset";
            this.btnHelpGenericAsset.Size = new System.Drawing.Size(16, 16);
            this.btnHelpGenericAsset.TabIndex = 37;
            this.btnHelpGenericAsset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHelpGenericAsset, "Nombre completo\r\n(Juan Pérez Vargas)");
            this.btnHelpGenericAsset.UseVisualStyleBackColor = false;
            // 
            // frmAssetEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 351);
            this.Controls.Add(this.btnHelpGenericAsset);
            this.Controls.Add(this.btnHelpAssetBranch);
            this.Controls.Add(this.btnHelpAssetLocation);
            this.Controls.Add(this.btnHelpAssetType);
            this.Controls.Add(this.chkRememberAssetBranch);
            this.Controls.Add(this.chkRememberAssetLocation);
            this.Controls.Add(this.chkRememberAssetType);
            this.Controls.Add(this.lblTitleAssetEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAssetTag);
            this.Controls.Add(this.lblAssetSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAssetPrice);
            this.Controls.Add(this.lblAssetBranch);
            this.Controls.Add(this.lblAssetLocation);
            this.Controls.Add(this.lblAssetStatus);
            this.Controls.Add(this.lblAssetType);
            this.Controls.Add(this.lblAssetDescription);
            this.Controls.Add(this.lblAssetId);
            this.Controls.Add(this.txtAssetWarrantyMonths);
            this.Controls.Add(this.dtpAssetPurchaseDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.chkGenericAsset);
            this.Controls.Add(this.txtAssetTag);
            this.Controls.Add(this.txtAssetSerialNumber);
            this.Controls.Add(this.txtAssetObservations);
            this.Controls.Add(this.txtAssetPrice);
            this.Controls.Add(this.cbAssetBranch);
            this.Controls.Add(this.cbAssetLocation);
            this.Controls.Add(this.cbAssetStatus);
            this.Controls.Add(this.cbAssetType);
            this.Controls.Add(this.txtAssetDescription);
            this.Controls.Add(this.txtAssetId);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssetEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAssetEdit";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAssetEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssetId;
        private System.Windows.Forms.TextBox txtAssetDescription;
        private System.Windows.Forms.ComboBox cbAssetType;
        private System.Windows.Forms.ComboBox cbAssetStatus;
        private System.Windows.Forms.ComboBox cbAssetLocation;
        private System.Windows.Forms.ComboBox cbAssetBranch;
        private System.Windows.Forms.MaskedTextBox txtAssetPrice;
        private System.Windows.Forms.TextBox txtAssetObservations;
        private System.Windows.Forms.TextBox txtAssetSerialNumber;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.CheckBox chkGenericAsset;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpAssetPurchaseDate;
        private System.Windows.Forms.MaskedTextBox txtAssetWarrantyMonths;
        private System.Windows.Forms.Label lblAssetId;
        private System.Windows.Forms.Label lblAssetDescription;
        private System.Windows.Forms.Label lblAssetType;
        private System.Windows.Forms.Label lblAssetStatus;
        private System.Windows.Forms.Label lblAssetLocation;
        private System.Windows.Forms.Label lblAssetBranch;
        private System.Windows.Forms.Label lblAssetPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAssetSerialNumber;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitleAssetEdit;
        private System.Windows.Forms.CheckBox chkRememberAssetType;
        private System.Windows.Forms.CheckBox chkRememberAssetLocation;
        private System.Windows.Forms.CheckBox chkRememberAssetBranch;
        private System.Windows.Forms.Button btnHelpAssetType;
        private System.Windows.Forms.Button btnHelpAssetLocation;
        private System.Windows.Forms.Button btnHelpAssetBranch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnHelpGenericAsset;
    }
}