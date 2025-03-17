using AssetControl.Classes;
using AssetControl.Exceptions;
using AssetControl.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmAssetEdit : Form
    {
        private bool _editMode;
        private Asset _asset;
        private bool _ok;        
        public frmAssetEdit()
        {
            InitializeComponent();
            _asset = new Asset();
            LoadWindow();
        }

        public frmAssetEdit(Asset asset)
        {
            InitializeComponent();
            _asset = asset;
            _editMode = true;
            LoadWindow();
        }

        public bool Ok
        {
            get { return _ok; }
        }

        private void LoadWindow()
        {
            LoadAssetTypes();
            LoadStatus();
            LoadLocations();
            LoadBranches();
            if (!_editMode)
            {
                Text = "Crear nuevo Activo";
                lblTitleAssetEdit.Text = "Crear Activo";
                lblTitleAssetEdit.Location = new Point(245, 15);
                cbAssetType.SelectedIndex = -1;
                cbAssetStatus.SelectedIndex = -1;
                cbAssetStatus.Enabled = true;
                cbAssetStatus.BackColor = Color.LightGoldenrodYellow;
                cbAssetLocation.SelectedIndex = -1;
                cbAssetBranch.SelectedIndex = -1;
                txtAssetDescription.Focus();
                btnSaveAndNew.Visible = true;
                dtpAssetPurchaseDate.Format = DateTimePickerFormat.Custom;
                dtpAssetPurchaseDate.CustomFormat = " ";
                dtpAssetPurchaseDate.Value = DateTime.Now;
            }
            else
            {
                Text = "Editar Activo";
                lblTitleAssetEdit.Text = "Editar Activo";
                lblTitleAssetEdit.Location = new Point(239, 15);
                txtAssetDescription.Text = _asset.Description;
                cbAssetType.SelectedValue = _asset.AssetType;
                cbAssetStatus.SelectedValue = _asset.Status;
                cbAssetLocation.SelectedValue = _asset.Location;
                cbAssetBranch.SelectedValue = _asset.Branch;
                cbAssetBranch.Enabled = false;
                txtAssetId.Text = _asset.Id.ToString();
                txtAssetPrice.Text = _asset.Price.ToString();
                txtAssetObservations.Text = _asset.Observations;
                txtAssetSerialNumber.Text = _asset.SerialNumber;
                txtAssetTag.Text = _asset.AssetTag;
                chkGenericAsset.Checked = _asset.GenericAsset;
                txtQuantity.Text = _asset.Quantity.ToString();
                if(_asset.PurchaseDate.HasValue)
                {
                    dtpAssetPurchaseDate.Value = (DateTime)_asset.PurchaseDate;
                }
                txtAssetWarrantyMonths.Text = _asset.WarrantyMonths.ToString();
                chkRememberAssetBranch.Visible = false;
                btnHelpAssetBranch.Visible = false;
                chkRememberAssetLocation.Visible = false;
                btnHelpAssetLocation.Visible = false;
                chkRememberAssetType.Visible = false;
                btnHelpAssetType.Visible = false;
            }
        }

        private void LoadAssetTypes()
        {
            List<AssetType> assetTypes = new List<AssetType>();
            using (AssetService service = new AssetService())
            {
                assetTypes = service.GetAssetTypesList();
            }
            cbAssetType.DataSource = assetTypes;
        }

        private void LoadStatus()
        {
            List<AssetStatus> assetStatus = new List<AssetStatus>();
            using (AssetService service = new AssetService())
            {
                assetStatus = service.GetAssetStatusesList();
            }
            cbAssetStatus.DataSource = assetStatus;
        }

        private void LoadLocations()
        {
            List<AssetLocation> locations = new List<AssetLocation>();
            using (AssetService service = new AssetService())
            {
                locations = service.GetLocationsList();
            }
            cbAssetLocation.DataSource = locations;
        }

        private void LoadBranches()
        {
            List<Branch> branches = new List<Branch>();
            using (AssetService service = new AssetService())
            {
                branches = service.GetBranchesList();
            }
            cbAssetBranch.DataSource = branches;
        }

        private bool SaveAsset()
        {
            Asset asset = new Asset()
            {
                Id = _editMode ? _asset.Id : 1,
                Description = txtAssetDescription.Text,
                AssetType = Convert.ToInt32(cbAssetType.SelectedValue),
                Status = Convert.ToInt32(cbAssetStatus.SelectedValue),
                Location = Convert.ToInt32(cbAssetLocation.SelectedValue),
                Branch = Convert.ToInt32(cbAssetBranch.SelectedValue),
                Price = string.IsNullOrEmpty(txtAssetPrice.Text) ? 0 : decimal.Parse(txtAssetPrice.Text, NumberStyles.Currency),
                Observations = txtAssetObservations.Text,
                SerialNumber = string.IsNullOrWhiteSpace(txtAssetSerialNumber.Text)? null : txtAssetSerialNumber.Text,
                AssetTag = string.IsNullOrWhiteSpace(txtAssetTag.Text) ? null : txtAssetTag.Text,
                GenericAsset = chkGenericAsset.Checked,
                Quantity = string.IsNullOrEmpty(txtQuantity.Text) ? 1 : Convert.ToInt32(txtQuantity.Text),
                PurchaseDate = dtpAssetPurchaseDate.Checked ? dtpAssetPurchaseDate.Value : (DateTime?)null,
                WarrantyMonths = string.IsNullOrEmpty(txtAssetWarrantyMonths.Text) ? 0 : Convert.ToInt32(txtAssetWarrantyMonths.Text)
            };
            
            if (_editMode && _asset.Equals(asset))
            {
                //do nothing, there are no changes
                return true;
            }

            var validator = new Validator<Asset>();
            try
            {
                validator.FormsValidation(asset);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "Description":
                        txtAssetDescription.Focus();
                        break;
                    case "Price":
                        txtAssetPrice.Focus();
                        txtAssetPrice.SelectAll();
                        break;
                    case "Quantity":
                        txtQuantity.Focus();
                        txtQuantity.SelectAll();
                        break;
                    case "WarrantyMonths":
                        txtAssetWarrantyMonths.Focus();
                        txtAssetWarrantyMonths.SelectAll();
                        break;
                    case "AssetType":
                        cbAssetType.Focus();
                        break;
                    case "Status":
                        cbAssetStatus.Focus();
                        break;
                    case "Location":
                        cbAssetLocation.Focus();
                        break;
                    case "Branch":
                        cbAssetBranch.Focus();
                        break;
                    default:
                        break;
                }
                return false;
            }

            string result = string.Empty;
            using (AssetService service = new AssetService())
            {
                result = service.SaveAsset(asset, _editMode ? EditType.Update : EditType.Insert);
            }
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //save audit log
            AuditRecord audit = new AuditRecord()
            {
                LogDate = DateTime.Now,
                UserId = User.Instance.UserId,
                Action = _editMode ? "Update Asset" : "Create new Asset",
                TableName = "assets",
                RecordId = _editMode ? asset.Id.ToString() : null,
                Details = _editMode ? AssetService.CreateDetailsText(asset, _asset) : $"Create new Asset: {asset.Description}"
            };
            return true;
        }

        private void ClearWindow()
        {
            txtAssetDescription.Text = null;
            if(!chkRememberAssetType.Checked)
            {
                cbAssetType.SelectedIndex = -1;
            }
            cbAssetStatus.SelectedIndex = -1;
            if (!chkRememberAssetLocation.Checked)
            {
                cbAssetLocation.SelectedIndex = -1;
            }
            if (!chkRememberAssetBranch.Checked)
            {
                cbAssetBranch.SelectedIndex = -1;
            }
            txtAssetPrice.Text = 0.ToString();
            txtAssetObservations.Text = null;
            txtAssetSerialNumber.Text = null;
            txtAssetTag.Text = null;
            chkGenericAsset.Checked = false;
            txtQuantity.Text = 1.ToString();
            dtpAssetPurchaseDate.Format = DateTimePickerFormat.Custom;
            dtpAssetPurchaseDate.CustomFormat = " ";
            dtpAssetPurchaseDate.Value = DateTime.Now;
            txtAssetWarrantyMonths.Text = 0.ToString();
            txtAssetDescription.Focus();
            dtpAssetPurchaseDate.Checked = false;
        }

        private void chkGenericAsset_CheckedChanged(object sender, EventArgs e)
        {
            txtQuantity.Enabled = chkGenericAsset.Checked;
            lblQuantity.Enabled = chkGenericAsset.Checked;
        }

        private void frmAssetEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                Cursor.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!SaveAsset())
                return;
            _ok = true;
            MessageBox.Show("Activo creado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (!SaveAsset())
                return;
            MessageBox.Show("Activo creado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearWindow();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.Clear();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.Text = 1.ToString();
            }
        }
        private void cbAssetType_Enter(object sender, EventArgs e)
        {
            //cbAssetType.DroppedDown = true;
        }

        private void cbAssetStatus_Enter(object sender, EventArgs e)
        {
            //cbAssetStatus.DroppedDown = true;
        }

        private void cbAssetLocation_Enter(object sender, EventArgs e)
        {
            //cbAssetLocation.DroppedDown = true;
        }

        private void cbAssetBranch_Enter(object sender, EventArgs e)
        {
            //cbAssetBranch.DroppedDown = true;
        }

        private void txtAssetPrice_Enter(object sender, EventArgs e)
        {
            txtAssetPrice.Clear();
        }

        private void txtAssetPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAssetPrice.Text.Replace("₡", "").Replace("_","").Trim()))
            {
                txtAssetPrice.Text = 0.ToString();
            }
        }
    }
}
