namespace AssetControl.Forms
{
    partial class frmPasswordChange
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
            this.txtNewPasswordConfirmEdit = new System.Windows.Forms.TextBox();
            this.txtNewPasswordEdit = new System.Windows.Forms.TextBox();
            this.lblNewPasswordEdit = new System.Windows.Forms.Label();
            this.lblNewPasswordConfirmEdit = new System.Windows.Forms.Label();
            this.btnCancelPasswordEdit = new System.Windows.Forms.Button();
            this.btnOkPasswordEdit = new System.Windows.Forms.Button();
            this.lblActualPasswordEdit = new System.Windows.Forms.Label();
            this.txtActualPasswordEdit = new System.Windows.Forms.TextBox();
            this.lblTitlePasswordEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPasswordConfirmEdit
            // 
            this.txtNewPasswordConfirmEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPasswordConfirmEdit.Location = new System.Drawing.Point(114, 105);
            this.txtNewPasswordConfirmEdit.MaxLength = 200;
            this.txtNewPasswordConfirmEdit.Name = "txtNewPasswordConfirmEdit";
            this.txtNewPasswordConfirmEdit.PasswordChar = '*';
            this.txtNewPasswordConfirmEdit.Size = new System.Drawing.Size(179, 23);
            this.txtNewPasswordConfirmEdit.TabIndex = 3;
            // 
            // txtNewPasswordEdit
            // 
            this.txtNewPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPasswordEdit.Location = new System.Drawing.Point(114, 75);
            this.txtNewPasswordEdit.MaxLength = 200;
            this.txtNewPasswordEdit.Name = "txtNewPasswordEdit";
            this.txtNewPasswordEdit.PasswordChar = '*';
            this.txtNewPasswordEdit.Size = new System.Drawing.Size(179, 23);
            this.txtNewPasswordEdit.TabIndex = 2;
            // 
            // lblNewPasswordEdit
            // 
            this.lblNewPasswordEdit.AutoSize = true;
            this.lblNewPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordEdit.Location = new System.Drawing.Point(32, 83);
            this.lblNewPasswordEdit.Name = "lblNewPasswordEdit";
            this.lblNewPasswordEdit.Size = new System.Drawing.Size(49, 15);
            this.lblNewPasswordEdit.TabIndex = 9;
            this.lblNewPasswordEdit.Text = "Nueva:";
            // 
            // lblNewPasswordConfirmEdit
            // 
            this.lblNewPasswordConfirmEdit.AutoSize = true;
            this.lblNewPasswordConfirmEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordConfirmEdit.Location = new System.Drawing.Point(32, 113);
            this.lblNewPasswordConfirmEdit.Name = "lblNewPasswordConfirmEdit";
            this.lblNewPasswordConfirmEdit.Size = new System.Drawing.Size(70, 15);
            this.lblNewPasswordConfirmEdit.TabIndex = 10;
            this.lblNewPasswordConfirmEdit.Text = "Confirme:";
            // 
            // btnCancelPasswordEdit
            // 
            this.btnCancelPasswordEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPasswordEdit.Location = new System.Drawing.Point(177, 143);
            this.btnCancelPasswordEdit.Name = "btnCancelPasswordEdit";
            this.btnCancelPasswordEdit.Size = new System.Drawing.Size(90, 25);
            this.btnCancelPasswordEdit.TabIndex = 23;
            this.btnCancelPasswordEdit.Text = "Cancelar";
            this.btnCancelPasswordEdit.UseVisualStyleBackColor = true;
            this.btnCancelPasswordEdit.Click += new System.EventHandler(this.btnCancelPasswordEdit_Click);
            // 
            // btnOkPasswordEdit
            // 
            this.btnOkPasswordEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkPasswordEdit.Location = new System.Drawing.Point(71, 143);
            this.btnOkPasswordEdit.Name = "btnOkPasswordEdit";
            this.btnOkPasswordEdit.Size = new System.Drawing.Size(90, 25);
            this.btnOkPasswordEdit.TabIndex = 22;
            this.btnOkPasswordEdit.Text = "Guardar";
            this.btnOkPasswordEdit.UseVisualStyleBackColor = true;
            this.btnOkPasswordEdit.Click += new System.EventHandler(this.btnOkPasswordEdit_Click);
            // 
            // lblActualPasswordEdit
            // 
            this.lblActualPasswordEdit.AutoSize = true;
            this.lblActualPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPasswordEdit.Location = new System.Drawing.Point(32, 53);
            this.lblActualPasswordEdit.Name = "lblActualPasswordEdit";
            this.lblActualPasswordEdit.Size = new System.Drawing.Size(56, 15);
            this.lblActualPasswordEdit.TabIndex = 15;
            this.lblActualPasswordEdit.Text = "Actual:";
            // 
            // txtActualPasswordEdit
            // 
            this.txtActualPasswordEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualPasswordEdit.Location = new System.Drawing.Point(114, 45);
            this.txtActualPasswordEdit.MaxLength = 200;
            this.txtActualPasswordEdit.Name = "txtActualPasswordEdit";
            this.txtActualPasswordEdit.PasswordChar = '*';
            this.txtActualPasswordEdit.Size = new System.Drawing.Size(179, 23);
            this.txtActualPasswordEdit.TabIndex = 1;
            // 
            // lblTitlePasswordEdit
            // 
            this.lblTitlePasswordEdit.AutoSize = true;
            this.lblTitlePasswordEdit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePasswordEdit.Location = new System.Drawing.Point(60, 13);
            this.lblTitlePasswordEdit.Name = "lblTitlePasswordEdit";
            this.lblTitlePasswordEdit.Size = new System.Drawing.Size(226, 24);
            this.lblTitlePasswordEdit.TabIndex = 17;
            this.lblTitlePasswordEdit.Text = "Cambiar Contraseña";
            // 
            // frmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 176);
            this.Controls.Add(this.txtNewPasswordConfirmEdit);
            this.Controls.Add(this.txtNewPasswordEdit);
            this.Controls.Add(this.lblNewPasswordEdit);
            this.Controls.Add(this.lblNewPasswordConfirmEdit);
            this.Controls.Add(this.btnCancelPasswordEdit);
            this.Controls.Add(this.btnOkPasswordEdit);
            this.Controls.Add(this.lblActualPasswordEdit);
            this.Controls.Add(this.txtActualPasswordEdit);
            this.Controls.Add(this.lblTitlePasswordEdit);
            this.KeyPreview = true;
            this.Name = "frmPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPasswordChange_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPasswordConfirmEdit;
        private System.Windows.Forms.TextBox txtNewPasswordEdit;
        private System.Windows.Forms.Label lblNewPasswordEdit;
        private System.Windows.Forms.Label lblNewPasswordConfirmEdit;
        private System.Windows.Forms.Button btnCancelPasswordEdit;
        private System.Windows.Forms.Button btnOkPasswordEdit;
        private System.Windows.Forms.Label lblActualPasswordEdit;
        private System.Windows.Forms.TextBox txtActualPasswordEdit;
        private System.Windows.Forms.Label lblTitlePasswordEdit;
    }
}