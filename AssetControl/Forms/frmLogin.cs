using AssetControl.Classes;
using AssetControl.Exceptions;
using AssetControl.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmLogin : Form
    {
        private bool _mousePressed;
        private int _mouseX;
        private int _mouseY;
        AppConfiguration _config = AppConfiguration.Instance;
        public frmLogin()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            txtUserLogin.Text = _config.AppUser;
            lblParroquia.Text += _config.Parish;
            lblUbicacion.Text = _config.Address;
        }

        #region Form Methods
        private void pnlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePressed = true;
            _mouseX = e.X;
            _mouseY = e.Y;
        }

        private void pnlLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousePressed)
            {
                int newX = this.Location.X + (e.X - _mouseX);
                int newY = this.Location.Y + (e.Y - _mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void pnlLeft_MouseUp(object sender, MouseEventArgs e)
        {
            _mousePressed = false;
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        //show or hide password characters
        private void pbPasswordLogin_Click(object sender, EventArgs e)
        {
            if (txtPasswordLogin.PasswordChar == '*')
            {
                txtPasswordLogin.PasswordChar = '\0';
            }
            else
            {
                txtPasswordLogin.PasswordChar = '*';
            }
        }
        #endregion

        private void btnEnterLogin_Click(object sender, EventArgs e)
        {
            User user = User.Instance;
            user.UserId = txtUserLogin.Text;
            user.Password = txtPasswordLogin.Text;
            user.UserName = "Not defined";
            user.Role = 1;
            user.RoleDescription = "None";

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
                        txtUserLogin.Focus();
                        break;
                    case "Password":
                        txtPasswordLogin.Focus();
                        break;
                }
                return;
            }

            //User validation on database
            UserService userService = new UserService();
            AuthenticationResult result = userService.UserValidation();

            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (!string.IsNullOrEmpty(result.UserProperty))
                {
                    switch (result.UserProperty)
                    {
                        case "User":
                            txtUserLogin.SelectAll();
                            txtUserLogin.Focus();
                            break;
                        case "Password":
                            txtPasswordLogin.SelectAll();
                            txtPasswordLogin.Focus();
                            break;
                    }
                }
                return;
            }
            //log user login
            AuditRecord record = new AuditRecord()
            {
                UserId = user.UserId,
                Action = "Login successful"
            };
            Utilities.SaveAuditRecord(record);

            //save current user in app.config
            if(user.UserId != _config.AppUser)
            {
                _config.AppUser = user.UserId;
                _config.SaveAppSettings();
            }

            frmMain ofrm = new frmMain();
            this.Hide();
            ofrm.ShowDialog();
            this.Close();
        }

        private void btnSettingsLogin_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Realizar cambios en esta pantalla puede provocar que la aplicación deje de funcionar" +
                "\n¿Está seguro que desea continuar?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (option == DialogResult.No)
                return;
            frmSettings ofrm = new frmSettings();
            ofrm.ShowDialog();
            AppConfiguration.Instance.ReloadAppSettings();
            LoadForm();
        }
    }
}
