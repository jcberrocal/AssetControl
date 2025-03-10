namespace AssetControl.Forms
{
    partial class frmLocationEdit
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
            this.lblObservations = new System.Windows.Forms.Label();
            this.btnCancelLocationEdit = new System.Windows.Forms.Button();
            this.btnOkLocationEdit = new System.Windows.Forms.Button();
            this.lblLocationDescription = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.txtLocationDescription = new System.Windows.Forms.TextBox();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.lblTitleLocationEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservations.Location = new System.Drawing.Point(19, 115);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(307, 13);
            this.lblObservations.TabIndex = 7;
            this.lblObservations.Text = "*El ID se genera automáticamente, una vez guardado";
            // 
            // btnCancelLocationEdit
            // 
            this.btnCancelLocationEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLocationEdit.Location = new System.Drawing.Point(171, 164);
            this.btnCancelLocationEdit.Name = "btnCancelLocationEdit";
            this.btnCancelLocationEdit.Size = new System.Drawing.Size(90, 25);
            this.btnCancelLocationEdit.TabIndex = 13;
            this.btnCancelLocationEdit.Text = "Cancelar";
            this.btnCancelLocationEdit.UseVisualStyleBackColor = true;
            this.btnCancelLocationEdit.Click += new System.EventHandler(this.btnCancelLocationEdit_Click);
            // 
            // btnOkLocationEdit
            // 
            this.btnOkLocationEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkLocationEdit.Location = new System.Drawing.Point(65, 164);
            this.btnOkLocationEdit.Name = "btnOkLocationEdit";
            this.btnOkLocationEdit.Size = new System.Drawing.Size(90, 25);
            this.btnOkLocationEdit.TabIndex = 12;
            this.btnOkLocationEdit.Text = "Guardar";
            this.btnOkLocationEdit.UseVisualStyleBackColor = true;
            this.btnOkLocationEdit.Click += new System.EventHandler(this.btnOkLocationEdit_Click);
            // 
            // lblLocationDescription
            // 
            this.lblLocationDescription.AutoSize = true;
            this.lblLocationDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDescription.Location = new System.Drawing.Point(21, 85);
            this.lblLocationDescription.Name = "lblLocationDescription";
            this.lblLocationDescription.Size = new System.Drawing.Size(91, 15);
            this.lblLocationDescription.TabIndex = 8;
            this.lblLocationDescription.Text = "Descripción:";
            // 
            // lblLocationId
            // 
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationId.Location = new System.Drawing.Point(21, 55);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(28, 15);
            this.lblLocationId.TabIndex = 11;
            this.lblLocationId.Text = "ID:";
            // 
            // txtLocationDescription
            // 
            this.txtLocationDescription.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtLocationDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationDescription.Location = new System.Drawing.Point(114, 77);
            this.txtLocationDescription.MaxLength = 200;
            this.txtLocationDescription.Name = "txtLocationDescription";
            this.txtLocationDescription.Size = new System.Drawing.Size(179, 23);
            this.txtLocationDescription.TabIndex = 11;
            // 
            // txtLocationId
            // 
            this.txtLocationId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationId.Location = new System.Drawing.Point(114, 47);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.ReadOnly = true;
            this.txtLocationId.Size = new System.Drawing.Size(179, 23);
            this.txtLocationId.TabIndex = 14;
            this.txtLocationId.TabStop = false;
            // 
            // lblTitleLocationEdit
            // 
            this.lblTitleLocationEdit.AutoSize = true;
            this.lblTitleLocationEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLocationEdit.Location = new System.Drawing.Point(41, 15);
            this.lblTitleLocationEdit.Name = "lblTitleLocationEdit";
            this.lblTitleLocationEdit.Size = new System.Drawing.Size(262, 24);
            this.lblTitleLocationEdit.TabIndex = 10;
            this.lblTitleLocationEdit.Text = "Crear nueva Ubicación";
            // 
            // frmLocationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.btnCancelLocationEdit);
            this.Controls.Add(this.btnOkLocationEdit);
            this.Controls.Add(this.lblLocationDescription);
            this.Controls.Add(this.lblLocationId);
            this.Controls.Add(this.txtLocationDescription);
            this.Controls.Add(this.txtLocationId);
            this.Controls.Add(this.lblTitleLocationEdit);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocationEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLocationEdit";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLocationEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Button btnCancelLocationEdit;
        private System.Windows.Forms.Button btnOkLocationEdit;
        private System.Windows.Forms.Label lblLocationDescription;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.TextBox txtLocationDescription;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label lblTitleLocationEdit;
    }
}