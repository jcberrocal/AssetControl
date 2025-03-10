using AssetControl.Classes;
using AssetControl.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmPasswordChange : Form
    {
        public frmPasswordChange()
        {
            InitializeComponent();
        }

        private void frmPasswordChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnCancelPasswordEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOkPasswordEdit_Click(object sender, EventArgs e)
        {
            AuthenticationResult result = new AuthenticationResult();
            string actualPassword = txtActualPasswordEdit.Text;
            string newPassword = txtNewPasswordEdit.Text;
            string confirmNewPassword = txtNewPasswordConfirmEdit.Text;
            using (UserService service = new UserService())
            {
                result = service.UserPasswordChange(actualPassword, newPassword, confirmNewPassword);
            }

            if(!result.Success)
            {
                MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrEmpty(result.UserProperty))
                {
                    switch (result.UserProperty)
                    {
                        case "ActualPassword":
                            txtActualPasswordEdit.SelectAll();
                            txtActualPasswordEdit.Focus();
                            break;
                        case "NewPassword":
                            txtNewPasswordEdit.SelectAll();
                            txtNewPasswordEdit.Focus();
                            break;
                        case "ConfirmNewPassword":
                            txtNewPasswordConfirmEdit.SelectAll();
                            txtNewPasswordConfirmEdit.Focus();
                            break;
                        default:
                            break;
                    }
                }
                return;
            }
            AuditRecord record = new AuditRecord()
            {
                UserId = User.Instance.UserId,
                Action = "Password changed",
                TableName = "users",
            };
            Utilities.SaveAuditRecord(record);
            MessageBox.Show("Contraseña cambiada exitosamente", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
