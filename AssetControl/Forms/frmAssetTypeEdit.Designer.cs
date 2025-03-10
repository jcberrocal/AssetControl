namespace AssetControl.Forms
{
    partial class frmAssetTypeEdit
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
            this.lblAssetTypeDescription = new System.Windows.Forms.Label();
            this.lblAssetTypeId = new System.Windows.Forms.Label();
            this.txtAssetTypeDescription = new System.Windows.Forms.TextBox();
            this.txtAssetTypeId = new System.Windows.Forms.TextBox();
            this.lblTitleAssetTypeEdit = new System.Windows.Forms.Label();
            this.btnCancelAssetTypeEdit = new System.Windows.Forms.Button();
            this.btnOkAssetTypeEdit = new System.Windows.Forms.Button();
            this.lblObservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAssetTypeDescription
            // 
            this.lblAssetTypeDescription.AutoSize = true;
            this.lblAssetTypeDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTypeDescription.Location = new System.Drawing.Point(20, 85);
            this.lblAssetTypeDescription.Name = "lblAssetTypeDescription";
            this.lblAssetTypeDescription.Size = new System.Drawing.Size(91, 15);
            this.lblAssetTypeDescription.TabIndex = 0;
            this.lblAssetTypeDescription.Text = "Descripción:";
            // 
            // lblAssetTypeId
            // 
            this.lblAssetTypeId.AutoSize = true;
            this.lblAssetTypeId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTypeId.Location = new System.Drawing.Point(20, 55);
            this.lblAssetTypeId.Name = "lblAssetTypeId";
            this.lblAssetTypeId.Size = new System.Drawing.Size(28, 15);
            this.lblAssetTypeId.TabIndex = 0;
            this.lblAssetTypeId.Text = "ID:";
            // 
            // txtAssetTypeDescription
            // 
            this.txtAssetTypeDescription.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAssetTypeDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTypeDescription.Location = new System.Drawing.Point(113, 77);
            this.txtAssetTypeDescription.MaxLength = 200;
            this.txtAssetTypeDescription.Name = "txtAssetTypeDescription";
            this.txtAssetTypeDescription.Size = new System.Drawing.Size(179, 23);
            this.txtAssetTypeDescription.TabIndex = 1;
            // 
            // txtAssetTypeId
            // 
            this.txtAssetTypeId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTypeId.Location = new System.Drawing.Point(113, 47);
            this.txtAssetTypeId.Name = "txtAssetTypeId";
            this.txtAssetTypeId.ReadOnly = true;
            this.txtAssetTypeId.Size = new System.Drawing.Size(179, 23);
            this.txtAssetTypeId.TabIndex = 6;
            this.txtAssetTypeId.TabStop = false;
            // 
            // lblTitleAssetTypeEdit
            // 
            this.lblTitleAssetTypeEdit.AutoSize = true;
            this.lblTitleAssetTypeEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAssetTypeEdit.Location = new System.Drawing.Point(41, 15);
            this.lblTitleAssetTypeEdit.Name = "lblTitleAssetTypeEdit";
            this.lblTitleAssetTypeEdit.Size = new System.Drawing.Size(262, 24);
            this.lblTitleAssetTypeEdit.TabIndex = 0;
            this.lblTitleAssetTypeEdit.Text = "Editar tipo de activo";
            // 
            // btnCancelAssetTypeEdit
            // 
            this.btnCancelAssetTypeEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAssetTypeEdit.Location = new System.Drawing.Point(170, 164);
            this.btnCancelAssetTypeEdit.Name = "btnCancelAssetTypeEdit";
            this.btnCancelAssetTypeEdit.Size = new System.Drawing.Size(90, 25);
            this.btnCancelAssetTypeEdit.TabIndex = 3;
            this.btnCancelAssetTypeEdit.Text = "Cancelar";
            this.btnCancelAssetTypeEdit.UseVisualStyleBackColor = true;
            this.btnCancelAssetTypeEdit.Click += new System.EventHandler(this.btnCancelAssetTypeEdit_Click);
            // 
            // btnOkAssetTypeEdit
            // 
            this.btnOkAssetTypeEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkAssetTypeEdit.Location = new System.Drawing.Point(64, 164);
            this.btnOkAssetTypeEdit.Name = "btnOkAssetTypeEdit";
            this.btnOkAssetTypeEdit.Size = new System.Drawing.Size(90, 25);
            this.btnOkAssetTypeEdit.TabIndex = 2;
            this.btnOkAssetTypeEdit.Text = "Guardar";
            this.btnOkAssetTypeEdit.UseVisualStyleBackColor = true;
            this.btnOkAssetTypeEdit.Click += new System.EventHandler(this.btnOkAssetTypeEdit_Click);
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservations.Location = new System.Drawing.Point(18, 115);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(307, 13);
            this.lblObservations.TabIndex = 0;
            this.lblObservations.Text = "*El ID se genera automáticamente, una vez guardado";
            // 
            // frmAssetTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.btnCancelAssetTypeEdit);
            this.Controls.Add(this.btnOkAssetTypeEdit);
            this.Controls.Add(this.lblAssetTypeDescription);
            this.Controls.Add(this.lblAssetTypeId);
            this.Controls.Add(this.txtAssetTypeDescription);
            this.Controls.Add(this.txtAssetTypeId);
            this.Controls.Add(this.lblTitleAssetTypeEdit);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssetTypeEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssetEdit";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAssetTypeEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssetTypeDescription;
        private System.Windows.Forms.Label lblAssetTypeId;
        private System.Windows.Forms.TextBox txtAssetTypeDescription;
        private System.Windows.Forms.TextBox txtAssetTypeId;
        private System.Windows.Forms.Label lblTitleAssetTypeEdit;
        private System.Windows.Forms.Button btnCancelAssetTypeEdit;
        private System.Windows.Forms.Button btnOkAssetTypeEdit;
        private System.Windows.Forms.Label lblObservations;
    }
}