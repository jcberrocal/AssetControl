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
using AssetControl.Exceptions;

namespace AssetControl.Forms
{
    public partial class frmUserEdit : Form
    {
        //User user;
        User _user;
        private bool _ok = false;
        private bool _editMode;
        public frmUserEdit()
        {
            InitializeComponent();
            _user = User.CreateNewUser();
            LoadWindow(false);
        }

        public frmUserEdit(User user)
        {
            InitializeComponent();
            _user = user;
            LoadWindow(true);
        }

        public bool Ok
        {
            get { return _ok; }
        }

        private void LoadWindow(bool editMode)
        {
            LoadUserRoles();
            if (!editMode)
            {
                Text = "Crear nuevo Usuario";
                lblTitleUserEdit.Text = "Crear Usuario";
                lblTitleUserEdit.Location = new Point(90, 15);
                //cbUserRolesEdit.SelectedIndex = 2; 
                txtUserIdEdit.Focus();
            }
            else
            {
                Text = "Editar Usuario";
                lblTitleUserEdit.Text = "Editar Usuario";
                lblTitleUserEdit.Location = new Point(84, 15);
                txtUserIdEdit.Text = _user.UserId;
                txtUserIdEdit.ReadOnly = true;
                txtUserNameEdit.Text = _user.UserName;
                txtPasswordEdit.Text = Encryptor.DecryptWord(_user.Password);
                txtPasswordConfirmEdit.Text = Encryptor.DecryptWord(_user.Password);
                cbUserRolesEdit.SelectedValue = _user.Role;
                btnHelpUserId.Visible = false;
                bntHelpPassword.Visible = false;
            }
            _editMode = editMode;
        }

        private void LoadUserRoles()
        {
            List<UserRole> roles = new List<UserRole>();
            using (UserService userService = new UserService())
            {
                roles = userService.GetUserRoleList();
            }
            cbUserRolesEdit.DataSource = roles;
        }

        private bool Validatepasswords()
        {
            if (txtPasswordEdit.Text.Trim() != txtPasswordConfirmEdit.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordEdit.Focus();
                txtPasswordEdit.SelectAll();
                return false;
            }
            return true;
        }

        private void btnOkUserEdit_Click(object sender, EventArgs e)
        {
            if (!Validatepasswords())
                return;

            User user = User.CreateNewUser();
            user.UserId = txtUserIdEdit.Text;
            user.UserName = txtUserNameEdit.Text;
            user.Password = Encryptor.EncryptWord(txtPasswordEdit.Text);
            user.Role = Convert.ToInt32(cbUserRolesEdit.SelectedValue);

            if (_editMode && _user.Equals(user))
            {
                //do nothing, there are no changes
                Close();
                return;
            }

            if(user.UserId.Contains(" "))
            {
                MessageBox.Show("El usuario no puede contener espacios en blanco", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserIdEdit.Focus();
                return;
            }

            var validator = new Validator<User>();

            try
            {
                validator.FormsValidation(user);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "UserId":
                        txtUserIdEdit.Focus();
                        break;
                    case "UserName":
                        txtUserNameEdit.Focus();
                        break;
                    case "Password":
                        txtPasswordEdit.Focus();
                        break;
                    case "Role":
                        cbUserRolesEdit.Focus();
                        break;
                    default:
                        break;
                }
                return;
            }

            string result = string.Empty;
            using (UserService service = new UserService())
            {
                if (!_editMode)
                {
                    UserExistsResult userExists = service.UserExists(user.UserId);
                    if (userExists.Exists)
                    {
                        MessageBox.Show($"Ya existe el usuario: {user.UserId}, nombre: {userExists.Name}" +
                            $"\nVerifique si el usuario se encuentra finalizado.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = service.SaveUser(user, EditType.Insert);
                }
                else
                {
                    result = service.SaveUser(user, EditType.Update);
                }
            }
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //save Audit log
            AuditRecord audit = new AuditRecord()
            {
                LogDate = DateTime.Now,
                UserId = User.Instance.UserId,
                TableName = "users",
                Action = _editMode ? "Edit User" : "Create new User",
                NewValue = $"Username : {user.UserName}, User role: {user.RoleDescription}",
                Details = _editMode ? $"Edit User: {user.UserName}" : $"Create new User: {user.UserName}",
            };
            if (_editMode)
            {
                audit.RecordId = user.UserId;
                audit.OldValue = $"Username : {_user.UserName}, User role: {_user.RoleDescription}";
            }
            
            Utilities.SaveAuditRecord(audit);

            _ok = true;
            Close();
        }

        private void btnCancelAssetTypeEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserEdit_KeyDown(object sender, KeyEventArgs e)
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

        private void frmUserEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
