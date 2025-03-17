namespace AssetControl.Forms
{
    partial class frmAddDetails
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
            this.lblTitleAddDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnSaveAddDetails = new System.Windows.Forms.Button();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.lblComboTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleAddDetails
            // 
            this.lblTitleAddDetails.AutoSize = true;
            this.lblTitleAddDetails.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddDetails.Location = new System.Drawing.Point(13, 13);
            this.lblTitleAddDetails.Name = "lblTitleAddDetails";
            this.lblTitleAddDetails.Size = new System.Drawing.Size(49, 15);
            this.lblTitleAddDetails.TabIndex = 0;
            this.lblTitleAddDetails.Text = "label1";
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtDetails.Location = new System.Drawing.Point(13, 63);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(332, 74);
            this.txtDetails.TabIndex = 1;
            // 
            // btnSaveAddDetails
            // 
            this.btnSaveAddDetails.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddDetails.Location = new System.Drawing.Point(141, 143);
            this.btnSaveAddDetails.Name = "btnSaveAddDetails";
            this.btnSaveAddDetails.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddDetails.TabIndex = 2;
            this.btnSaveAddDetails.Text = "Guardar";
            this.btnSaveAddDetails.UseVisualStyleBackColor = true;
            this.btnSaveAddDetails.Click += new System.EventHandler(this.btnSaveAddDetails_Click);
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbOptions.DisplayMember = "ReasonDescription";
            this.cbOptions.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(145, 30);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(200, 23);
            this.cbOptions.TabIndex = 24;
            this.cbOptions.ValueMember = "RetirementReason";
            this.cbOptions.Visible = false;
            // 
            // lblComboTitle
            // 
            this.lblComboTitle.AutoSize = true;
            this.lblComboTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboTitle.Location = new System.Drawing.Point(13, 38);
            this.lblComboTitle.Name = "lblComboTitle";
            this.lblComboTitle.Size = new System.Drawing.Size(98, 15);
            this.lblComboTitle.TabIndex = 25;
            this.lblComboTitle.Text = "Razón retiro:";
            this.lblComboTitle.Visible = false;
            // 
            // frmAddDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 172);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.lblComboTitle);
            this.Controls.Add(this.btnSaveAddDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblTitleAddDetails);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar detalle";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddDetails_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAddDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnSaveAddDetails;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Label lblComboTitle;
    }
}