using AssetControl.Classes;
using AssetControl.Exceptions;
using AssetControl.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmAssetTypeEdit : Form
    {
        private bool _editMode;
        private AssetType _assetType;
        private bool _ok;
        public frmAssetTypeEdit()
        {
            InitializeComponent();
            _editMode = false;
            LoadWindow();
        }
        internal frmAssetTypeEdit(AssetType assetType)
        {
            InitializeComponent();
            _assetType = assetType;
            _editMode = true;
            LoadWindow();
        }

        public bool Ok
        {
            get { return _ok; }
        }

        private void LoadWindow()
        {
            if (!_editMode)
            {
                Text = "Crear nuevo Tipo de activo";
                lblTitleAssetTypeEdit.Text = "Crear Tipo de Activo";
                lblTitleAssetTypeEdit.Location = new Point(47, 15);
                lblObservations.Visible = true;                
            }
            else
            {
                Text = "Editar Tipo de Activo";
                lblTitleAssetTypeEdit.Location = new Point(41, 15);
                lblObservations.Visible = false;
                txtAssetTypeId.Text = _assetType.AssetTypeId.ToString();
                txtAssetTypeDescription.Text = _assetType.TypeDescription.ToString();
            }
            _ok = false;
        }

        private void btnOkAssetTypeEdit_Click(object sender, EventArgs e)
        {
            AssetType assetType = new AssetType();
            assetType.TypeDescription = txtAssetTypeDescription.Text;
            if (_editMode)
            {
                assetType.AssetTypeId = _assetType.AssetTypeId;
                if (_assetType.Equals(assetType))
                {
                    //do nothing, there are no changes
                    Close();
                    return;
                }  
            }           
            var validator = new Validator<AssetType>();

            try
            {
                validator.FormsValidation(assetType);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "TypeDescription":
                        txtAssetTypeDescription.Focus();
                        break;
                    default:
                        break;
                }
                return;
            }

            string result = string.Empty;
            using (AssetService service = new AssetService())
            {
                if (!_editMode)
                {
                    result = service.SaveAssetType(assetType, EditType.Insert);
                }
                else
                {
                    result = service.SaveAssetType(assetType, EditType.Update);
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
                TableName = "asset_types",
                Action = _editMode ? $"Edit Asset Type" : $"Create Asset Type",
                NewValue = assetType.TypeDescription
            };
            if(_editMode)
            {
                audit.RecordId = assetType.AssetTypeId.ToString();
                audit.OldValue = _assetType.TypeDescription;
            }

            Utilities.SaveAuditRecord(audit);

            _ok = true;
            Close();
        }

        private void btnCancelAssetTypeEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAssetTypeEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
