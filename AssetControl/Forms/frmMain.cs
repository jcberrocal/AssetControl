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
    public partial class frmMain : Form
    {
        User user = User.Instance;
        public frmMain()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            lblUserMain.Text = $"Usuario: {user.UserName}";
            lblRoleMain.Text = $"Perfil: {user.RoleDescription}";
            if (user.Role == 1)
            {
                tsButtonUsers.Visible = true;
                tsSeparator8.Visible = true;
                btnSettingsMain.Visible = true;
            }
            else
            {
                tsButtonUsers.Visible = false;
                tsSeparator8.Visible = false;
                btnSettingsMain.Visible = false;
            }
        }
        #region Form Methods
        private void tsButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettingsMain_Click(object sender, EventArgs e)
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

        #endregion

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tsButtonAbout.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (!tsButtonAudit.Visible)
                {
                    tsButtonAudit.Visible = true;
                    tsSeparator9.Visible = true;
                }
                else
                {
                    tsButtonAudit.Visible = false;
                    tsSeparator9.Visible = false;
                }
            }
        }

        private void tsButtonUsers_Click(object sender, EventArgs e)
        {
            if (User.Instance.Role == 1)
            {
                frmUsers frm = frmUsers.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.Activate();
                //RefreshWindowsButton(); 
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a esta opción", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsButtonPassword_Click(object sender, EventArgs e)
        {
            using (frmPasswordChange frm = new frmPasswordChange())
            {
                frm.ShowDialog();
            }
        }

        private void tsButtonAssetType_Click(object sender, EventArgs e)
        {
            frmAssetTypes frm = frmAssetTypes.Instance();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
            //RefreshWindowsButton();
        }

        private void tsButtonBranches_Click(object sender, EventArgs e)
        {
            frmBranches frm = frmBranches.Instance();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
            //RefreshWindowsButton();
        }

        private void tsButtonLocations_Click(object sender, EventArgs e)
        {
            frmLocations frm = frmLocations.Instance();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
            //RefreshWindowsButton();
        }

        private void tsButtonReport_Click(object sender, EventArgs e)
        {
            //RefreshWindowsButton();
        }

        private void tsButtonAudit_Click(object sender, EventArgs e)
        {
            //RefreshWindowsButton();
        }

        private void tsButtonAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void tsButtonAssets_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>() { "asset_locations", "asset_types", "branches" };
            string requirementsValidation;
            using (UserService service = new UserService())
            {
                requirementsValidation = service.RequirementsValidation(lst);
            }

            if (!string.IsNullOrEmpty(requirementsValidation))
            {
                MessageBox.Show(requirementsValidation, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmAssets frm = frmAssets.Instance();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        public void RefreshWindowsButton()
        {
            tsButtonPassword.DropDownItems.Clear();
            foreach (Form childForm in this.MdiChildren)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(childForm.Text);
                menuItem.Click += (s, args) => childForm.Activate();
                tsButtonPassword.DropDownItems.Add(menuItem);

                tsButtonPassword.DropDown.Location = new Point
                                                    (
                                                        tsButtonPassword.Bounds.Left,
                                                        tsButtonPassword.Bounds.Bottom
                                                    );
            }
        }
    }
}
