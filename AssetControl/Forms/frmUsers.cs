using AssetControl.Classes;
using AssetControl.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmUsers : frmBase
    {
        private static frmUsers _instance;
        private bool activeOnly;

        public frmUsers()
        { 
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            activeOnly = true;
        }
        
        public static frmUsers Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmUsers();
            }
            return _instance;
        }

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain mainForm = (frmMain)this.MdiParent;
            //mainForm.RefreshWindowsButton();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            dtgUsers.DataSource = null;
            string description = txtUserName.Text;
            int role = Convert.ToInt32(cbUserRoles.SelectedValue);
            QueryResult<User> results = new QueryResult<User>();

            using (UserService userService = new UserService())
            {
                results = userService.GetUserList(description, role, activeOnly);
            }
            if (!string.IsNullOrEmpty(results.ErrorMessage))
            {
                MessageBox.Show($"Error: {results.ErrorMessage}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (results.Data.Count == 0)
            {
                MessageBox.Show("No se encontraron datos", "Sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dtgUsers.DataSource = results.Data;
        }

        private void cbUserRoles_DropDown(object sender, EventArgs e)
        {
            if (cbUserRoles.DataSource == null)
            {
                List<UserRole> roles = new List<UserRole>();
                using (UserService userService = new UserService())
                {
                    roles = userService.GetUserRoleList();
                }
                cbUserRoles.DataSource = roles;
                cbUserRoles.SelectedIndex = -1;
            }
        }

        private void tsButtonUserNew_Click(object sender, EventArgs e)
        {
            bool ok;
            using (frmUserEdit ofrm = new frmUserEdit())
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
            {
                btnSearchUser.PerformClick();
            }

        }

        private void tsButtonUserEdit_Click(object sender, EventArgs e)
        {
            if(dtgUsers.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgUsers.SelectedRows[0];
            User user = User.CreateNewUser();
            user.UserId = selectedRow.Cells["userId"].Value.ToString();
            user.UserName = selectedRow.Cells["userName"].Value.ToString();
            user.Role = Convert.ToInt32(selectedRow.Cells["role"].Value);
            user.Password = selectedRow.Cells["password"].Value.ToString();

            bool ok;
            using (frmUserEdit ofrm = new frmUserEdit(user))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if(ok)
            {
                btnSearchUser.PerformClick();
            }
        }

        private void tsButtonUserEndate_Click(object sender, EventArgs e)
        {
            if (dtgUsers.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgUsers.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value != null ||
                selectedRow.Cells["endDate"].Value != DBNull.Value)
            {
                MessageBox.Show("El usuario ya se encuentra finalizado",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool ok;
            string details;
            using (frmAddDetails ofrm = new frmAddDetails("Inactivar Usuario"))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
            }
            if (ok)
            {
                User user = User.CreateNewUser();
                user = (User)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (UserService service = new UserService())
                {
                    result = service.SaveUser(user, EditType.Endate);
                }
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuditRecord audit = new AuditRecord
                {
                    LogDate = DateTime.Now,
                    UserId = User.Instance.UserId,
                    TableName = "users",
                    Action = $"Endate User: {user.UserName}",
                    RecordId = user.UserId,
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                //refresh grid
                btnSearchUser.PerformClick();
            }
        }

        private void frmUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnSearchUser.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10)
            {
                //ReactivateUser();
                e.SuppressKeyPress = true;
            }
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            activeOnly = chkActiveOnly.Checked;
        }
    }
}
