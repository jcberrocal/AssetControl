using AssetControl.Logic;
using AssetControl.Classes;
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
    public partial class frmSettings : Form
    {
        private readonly AppConfiguration config = AppConfiguration.Instance;
        public frmSettings()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            txtServerConfig.Text = config.Server.ToString();
            txtUserConfig.Text = config.User.ToString();
            txtPasswordConfig.Text = config.Password.ToString();
            txtPortConfig.Text = config.Port.ToString() ?? 5432.ToString();
            txtDataBaseConfig.Text = config.DataBase.ToString();
            txtParishConfig.Text = config.Parish.ToString();
            txtAddressConfig.Text = config.Address.ToString();
        }

        private void btnCancelConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private bool SaveConfig()
        {
            config.Server = txtServerConfig.Text;
            config.User = txtUserConfig.Text;
            config.Password = txtPasswordConfig.Text;
            if (!ValidatePort())
                return false;
            config.Port = Convert.ToInt32(txtPortConfig.Text);
            config.DataBase = txtDataBaseConfig.Text;
            config.Parish = txtParishConfig.Text;
            config.Address = txtAddressConfig.Text;
            return true;
        }

        private bool ValidatePort()
        {
            if (string.IsNullOrEmpty(txtPortConfig.Text))
            {
                MessageBox.Show("El campo Port no debe quedar vacío", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPortConfig.Focus();
                return false;
            }
            if (!Int32.TryParse(txtPortConfig.Text, out int _))
            {
                MessageBox.Show("El campo Port debe ser un número entero", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPortConfig.SelectAll();
                txtPortConfig.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateFields()
        {
            var validator = new Validator<AppConfiguration>();
            try
            {
                validator.FormsValidation(config);
                return true;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "Server":
                        txtServerConfig.SelectAll();
                        txtServerConfig.Focus();
                        break;
                    case "User":
                        txtUserConfig.SelectAll();
                        txtUserConfig.Focus();
                        break;
                    case "Password":
                        txtPasswordConfig.SelectAll();
                        txtPasswordConfig.Focus();
                        break;
                    case "Port":
                        txtPortConfig.SelectAll();
                        txtPortConfig.Focus();
                        break;
                    case "Database":
                        txtDataBaseConfig.SelectAll();
                        txtDataBaseConfig.Focus();
                        break;
                    case "Parish":
                        txtParishConfig.SelectAll();
                        txtParishConfig.Focus();
                        break;
                    case "Address":
                        txtAddressConfig.SelectAll();
                        txtAddressConfig.Focus();
                        break;
                    default:
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la configuración: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private void btnOkConfig_Click(object sender, EventArgs e)
        {
            if(!SaveConfig())
                return;
            if (!ValidateFields())
                return;
            config.SaveAppSettings();
            AuditRecord record = new AuditRecord()
            {
                UserId = User.Instance.UserId,
                Action = "Change Settings"
            };
            Utilities.SaveAuditRecord(record);
            this.Close();            
        }

        private void btnTestConnectionConfig_Click(object sender, EventArgs e)
        {
            if (!SaveConfig())
                return;
            if (!ValidateFields())
                return;
            bool isConnected = Utilities.TestDBConnection();
            if (!isConnected)
            {
                MessageBox.Show("No es posible establecer la conexión a la base de datos." +
                    "\nVerifique los datos ingresados e intente de nuevo", "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conexión exitosa","Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
