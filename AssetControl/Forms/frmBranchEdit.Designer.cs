namespace AssetControl.Forms
{
    partial class frmBranchEdit
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
            this.lbldObservations = new System.Windows.Forms.Label();
            this.btnCancelBranchEdit = new System.Windows.Forms.Button();
            this.btnOkBranchEdit = new System.Windows.Forms.Button();
            this.lblBranchDescription = new System.Windows.Forms.Label();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.txtBranchDescription = new System.Windows.Forms.TextBox();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.lblTitleBranchEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldObservations
            // 
            this.lbldObservations.AutoSize = true;
            this.lbldObservations.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldObservations.Location = new System.Drawing.Point(18, 115);
            this.lbldObservations.Name = "lbldObservations";
            this.lbldObservations.Size = new System.Drawing.Size(307, 13);
            this.lbldObservations.TabIndex = 7;
            this.lbldObservations.Text = "*El ID se genera automáticamente, una vez guardado";
            // 
            // btnCancelBranchEdit
            // 
            this.btnCancelBranchEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBranchEdit.Location = new System.Drawing.Point(170, 164);
            this.btnCancelBranchEdit.Name = "btnCancelBranchEdit";
            this.btnCancelBranchEdit.Size = new System.Drawing.Size(90, 25);
            this.btnCancelBranchEdit.TabIndex = 3;
            this.btnCancelBranchEdit.Text = "Cancelar";
            this.btnCancelBranchEdit.UseVisualStyleBackColor = true;
            this.btnCancelBranchEdit.Click += new System.EventHandler(this.btnCancelBranchEdit_Click);
            // 
            // btnOkBranchEdit
            // 
            this.btnOkBranchEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkBranchEdit.Location = new System.Drawing.Point(64, 164);
            this.btnOkBranchEdit.Name = "btnOkBranchEdit";
            this.btnOkBranchEdit.Size = new System.Drawing.Size(90, 25);
            this.btnOkBranchEdit.TabIndex = 2;
            this.btnOkBranchEdit.Text = "Guardar";
            this.btnOkBranchEdit.UseVisualStyleBackColor = true;
            this.btnOkBranchEdit.Click += new System.EventHandler(this.btnOkBranchEdit_Click);
            // 
            // lblBranchDescription
            // 
            this.lblBranchDescription.AutoSize = true;
            this.lblBranchDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchDescription.Location = new System.Drawing.Point(20, 85);
            this.lblBranchDescription.Name = "lblBranchDescription";
            this.lblBranchDescription.Size = new System.Drawing.Size(91, 15);
            this.lblBranchDescription.TabIndex = 12;
            this.lblBranchDescription.Text = "Descripción:";
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchId.Location = new System.Drawing.Point(20, 55);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(28, 15);
            this.lblBranchId.TabIndex = 11;
            this.lblBranchId.Text = "ID:";
            // 
            // txtBranchDescription
            // 
            this.txtBranchDescription.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtBranchDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchDescription.Location = new System.Drawing.Point(113, 77);
            this.txtBranchDescription.MaxLength = 200;
            this.txtBranchDescription.Name = "txtBranchDescription";
            this.txtBranchDescription.Size = new System.Drawing.Size(179, 23);
            this.txtBranchDescription.TabIndex = 1;
            // 
            // txtBranchId
            // 
            this.txtBranchId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchId.Location = new System.Drawing.Point(113, 47);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.ReadOnly = true;
            this.txtBranchId.Size = new System.Drawing.Size(179, 23);
            this.txtBranchId.TabIndex = 14;
            this.txtBranchId.TabStop = false;
            // 
            // lblTitleBranchEdit
            // 
            this.lblTitleBranchEdit.AutoSize = true;
            this.lblTitleBranchEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBranchEdit.Location = new System.Drawing.Point(89, 15);
            this.lblTitleBranchEdit.Name = "lblTitleBranchEdit";
            this.lblTitleBranchEdit.Size = new System.Drawing.Size(166, 24);
            this.lblTitleBranchEdit.TabIndex = 10;
            this.lblTitleBranchEdit.Text = "Editar Filial";
            // 
            // frmBranchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.lbldObservations);
            this.Controls.Add(this.btnCancelBranchEdit);
            this.Controls.Add(this.btnOkBranchEdit);
            this.Controls.Add(this.lblBranchDescription);
            this.Controls.Add(this.lblBranchId);
            this.Controls.Add(this.txtBranchDescription);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.lblTitleBranchEdit);
            this.Name = "frmBranchEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBranchEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldObservations;
        private System.Windows.Forms.Button btnCancelBranchEdit;
        private System.Windows.Forms.Button btnOkBranchEdit;
        private System.Windows.Forms.Label lblBranchDescription;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.TextBox txtBranchDescription;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label lblTitleBranchEdit;
    }
}