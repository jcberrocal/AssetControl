namespace AssetControl.Forms
{
    partial class frmBranches
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
            this.btnSearchBranch = new System.Windows.Forms.Button();
            this.txtBranchDescription = new System.Windows.Forms.TextBox();
            this.lblBranchDescription = new System.Windows.Forms.Label();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.tsBranches = new System.Windows.Forms.ToolStrip();
            this.tsButtonBranchNew = new System.Windows.Forms.ToolStripButton();
            this.tsBranchSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonBranchEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBranchSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonBranchEndate = new System.Windows.Forms.ToolStripButton();
            this.tsBranchSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgBranches = new System.Windows.Forms.DataGridView();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilterSection.SuspendLayout();
            this.pnlDataSection.SuspendLayout();
            this.tsBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.Controls.Add(this.tsBranches);
            this.pnlFilterSection.Controls.Add(this.btnSearchBranch);
            this.pnlFilterSection.Controls.Add(this.txtBranchDescription);
            this.pnlFilterSection.Controls.Add(this.lblBranchDescription);
            this.pnlFilterSection.Controls.Add(this.chkActiveOnly);
            // 
            // pnlDataSection
            // 
            this.pnlDataSection.Controls.Add(this.dtgBranches);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(383, 9);
            this.lblTitle.Size = new System.Drawing.Size(310, 24);
            this.lblTitle.Text = "Mantenimiento de Filiales";
            // 
            // btnSearchBranch
            // 
            this.btnSearchBranch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBranch.Location = new System.Drawing.Point(306, 2);
            this.btnSearchBranch.Name = "btnSearchBranch";
            this.btnSearchBranch.Size = new System.Drawing.Size(90, 23);
            this.btnSearchBranch.TabIndex = 2;
            this.btnSearchBranch.Text = "Buscar(F3)";
            this.btnSearchBranch.UseVisualStyleBackColor = true;
            this.btnSearchBranch.Click += new System.EventHandler(this.btnSearchBranch_Click);
            // 
            // txtBranchDescription
            // 
            this.txtBranchDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchDescription.Location = new System.Drawing.Point(65, 2);
            this.txtBranchDescription.MaxLength = 200;
            this.txtBranchDescription.Name = "txtBranchDescription";
            this.txtBranchDescription.Size = new System.Drawing.Size(200, 23);
            this.txtBranchDescription.TabIndex = 1;
            // 
            // lblBranchDescription
            // 
            this.lblBranchDescription.AutoSize = true;
            this.lblBranchDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchDescription.Location = new System.Drawing.Point(3, 10);
            this.lblBranchDescription.Name = "lblBranchDescription";
            this.lblBranchDescription.Size = new System.Drawing.Size(56, 15);
            this.lblBranchDescription.TabIndex = 100;
            this.lblBranchDescription.Text = "Nombre:";
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Checked = true;
            this.chkActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveOnly.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiveOnly.Location = new System.Drawing.Point(402, 6);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(187, 19);
            this.chkActiveOnly.TabIndex = 9;
            this.chkActiveOnly.Text = "Sólo sucursales activas";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // tsBranches
            // 
            this.tsBranches.AutoSize = false;
            this.tsBranches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBranches.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBranches.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonBranchNew,
            this.tsBranchSeparator1,
            this.tsButtonBranchEdit,
            this.tsBranchSeparator2,
            this.tsButtonBranchEndate,
            this.tsBranchSeparator3});
            this.tsBranches.Location = new System.Drawing.Point(0, 83);
            this.tsBranches.Name = "tsBranches";
            this.tsBranches.Size = new System.Drawing.Size(1052, 36);
            this.tsBranches.TabIndex = 11;
            this.tsBranches.Text = "toolStrip1";
            // 
            // tsButtonBranchNew
            // 
            this.tsButtonBranchNew.AutoSize = false;
            this.tsButtonBranchNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonBranchNew.Image = global::AssetControl.Properties.Resources.new_32;
            this.tsButtonBranchNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonBranchNew.Name = "tsButtonBranchNew";
            this.tsButtonBranchNew.Size = new System.Drawing.Size(51, 36);
            this.tsButtonBranchNew.Text = "Nuevo";
            this.tsButtonBranchNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonBranchNew.Click += new System.EventHandler(this.tsButtonBranchNew_Click);
            // 
            // tsBranchSeparator1
            // 
            this.tsBranchSeparator1.Name = "tsBranchSeparator1";
            this.tsBranchSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonBranchEdit
            // 
            this.tsButtonBranchEdit.AutoSize = false;
            this.tsButtonBranchEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonBranchEdit.Image = global::AssetControl.Properties.Resources.edit_32;
            this.tsButtonBranchEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonBranchEdit.Name = "tsButtonBranchEdit";
            this.tsButtonBranchEdit.Size = new System.Drawing.Size(51, 36);
            this.tsButtonBranchEdit.Text = "Editar";
            this.tsButtonBranchEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonBranchEdit.Click += new System.EventHandler(this.tsButtonBranchEdit_Click);
            // 
            // tsBranchSeparator2
            // 
            this.tsBranchSeparator2.Name = "tsBranchSeparator2";
            this.tsBranchSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsButtonBranchEndate
            // 
            this.tsButtonBranchEndate.AutoSize = false;
            this.tsButtonBranchEndate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtonBranchEndate.Image = global::AssetControl.Properties.Resources.toggle_32;
            this.tsButtonBranchEndate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchEndate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonBranchEndate.Name = "tsButtonBranchEndate";
            this.tsButtonBranchEndate.Size = new System.Drawing.Size(70, 36);
            this.tsButtonBranchEndate.Text = "Finalizar";
            this.tsButtonBranchEndate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonBranchEndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonBranchEndate.Click += new System.EventHandler(this.tsButtonBranchEndate_Click);
            // 
            // tsBranchSeparator3
            // 
            this.tsBranchSeparator3.Name = "tsBranchSeparator3";
            this.tsBranchSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // dtgBranches
            // 
            this.dtgBranches.AllowUserToAddRows = false;
            this.dtgBranches.AllowUserToDeleteRows = false;
            this.dtgBranches.AutoGenerateColumns = false;
            this.dtgBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchId,
            this.branchDescription,
            this.endDate});
            this.dtgBranches.DataSource = this.branchBindingSource;
            this.dtgBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBranches.Location = new System.Drawing.Point(0, 0);
            this.dtgBranches.MultiSelect = false;
            this.dtgBranches.Name = "dtgBranches";
            this.dtgBranches.ReadOnly = true;
            this.dtgBranches.RowHeadersVisible = false;
            this.dtgBranches.RowHeadersWidth = 20;
            this.dtgBranches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgBranches.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBranches.Size = new System.Drawing.Size(1052, 357);
            this.dtgBranches.TabIndex = 1;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(AssetControl.Classes.Branch);
            // 
            // branchId
            // 
            this.branchId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.branchId.DataPropertyName = "BranchId";
            this.branchId.DividerWidth = 1;
            this.branchId.HeaderText = "ID";
            this.branchId.Name = "branchId";
            this.branchId.ReadOnly = true;
            this.branchId.Width = 50;
            // 
            // branchDescription
            // 
            this.branchDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.branchDescription.DataPropertyName = "BranchDescription";
            this.branchDescription.DividerWidth = 1;
            this.branchDescription.HeaderText = "Descripción";
            this.branchDescription.Name = "branchDescription";
            this.branchDescription.ReadOnly = true;
            this.branchDescription.Width = 350;
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
            // frmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.Name = "frmBranches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmBranches";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBranches_KeyDown);
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterSection.PerformLayout();
            this.pnlDataSection.ResumeLayout(false);
            this.tsBranches.ResumeLayout(false);
            this.tsBranches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchBranch;
        private System.Windows.Forms.TextBox txtBranchDescription;
        private System.Windows.Forms.Label lblBranchDescription;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.ToolStrip tsBranches;
        private System.Windows.Forms.ToolStripButton tsButtonBranchNew;
        private System.Windows.Forms.ToolStripSeparator tsBranchSeparator1;
        private System.Windows.Forms.ToolStripButton tsButtonBranchEdit;
        private System.Windows.Forms.ToolStripSeparator tsBranchSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonBranchEndate;
        private System.Windows.Forms.ToolStripSeparator tsBranchSeparator3;
        private System.Windows.Forms.DataGridView dtgBranches;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
    }
}