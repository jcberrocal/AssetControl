using AssetControl.Classes;
using AssetControl.Logic;
using System;
using System.Windows.Forms;

namespace AssetControl.Forms
{
    public partial class frmAssetTypes : frmBase
    {
        private static frmAssetTypes _instance;
        private bool _activeOnly;

        public frmAssetTypes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _activeOnly = true;
            LoadForm();
        }

        public static frmAssetTypes Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmAssetTypes();
            }
            return _instance;
        }

        private void LoadForm()
        {
            if(User.Instance.Role != 1)
            {
                chkActiveOnly.Enabled = false;
                tsButtonAssetTypeEndate.Enabled = false;
            }
            if (User.Instance.Role == 3)
            {
                tsButtonAssetTypeEdit.Enabled = false;
                tsButtonAssetTypeNew.Enabled = false;
            }
            txtAssetTypeDescription.Focus();
        }

        private void btnSearchAssetType_Click(object sender, EventArgs e)
        {
            string description = txtAssetTypeDescription.Text;
            QueryResult<AssetType> results = new QueryResult<AssetType>();
            using (AssetService assetService = new AssetService())
            {
                results = assetService.GetAssetTypes(description, _activeOnly);
            }
            if (!string.IsNullOrEmpty(results.ErrorMessage))
            {
                MessageBox.Show($"Error: {results.ErrorMessage}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (results.Data.Count == 0)
                MessageBox.Show("No se encontraron datos", "Sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dtgAssetType.DataSource = results.Data;
        }

        private void tsButtonAssetTypeNew_Click(object sender, EventArgs e)
        {
            bool ok;
            using (frmAssetTypeEdit frm = new frmAssetTypeEdit())
            {
                frm.ShowDialog();
                ok = frm.Ok;
            }
            if (ok)
                btnSearchAssetType.PerformClick();            
        }

        private void tsButtonAssetTypeEdit_Click(object sender, EventArgs e)
        {
            if (dtgAssetType.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgAssetType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgAssetType.SelectedRows[0];
            AssetType assetType = (AssetType)selectedRow.DataBoundItem;

            bool ok;
            using (frmAssetTypeEdit ofrm = new frmAssetTypeEdit(assetType))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
            {
                btnSearchAssetType.PerformClick();
            }
        }

        private void tsAssetTypeEndate_Click(object sender, EventArgs e)
        {
            if (dtgAssetType.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgAssetType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgAssetType.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value != null)
            {
                MessageBox.Show("No es posible finalizar el registro,\nya se encuentra finalizado",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ok;
            string details;
            using (frmAddDetails frm = new frmAddDetails("Inactivar Tipo de Activo"))
            {
                frm.ShowDialog();
                ok = frm.Ok;
                details = frm.Details;
            }
            if (ok)
            {
                AssetType assetType = (AssetType)selectedRow.DataBoundItem;                
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveAssetType(assetType, EditType.Endate);
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
                    Action = $"Endate Asset Type: {assetType.TypeDescription}",
                    TableName = "asset_types",
                    RecordId = assetType.AssetTypeId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                //refresh grid
                btnSearchAssetType.PerformClick();
            }
        }

        private void ReactivateAssetType()
        {
            if (dtgAssetType.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgAssetType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow selectedRow = dtgAssetType.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value == null ||
                selectedRow.Cells["endDate"].Value == DBNull.Value)
            {
                MessageBox.Show("No es posible reactivar el registro,\nya se encuentra activo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ok;
            string details;
            using (frmAddDetails frm = new frmAddDetails("Reactivar Tipo de Activo"))
            {
                frm.ShowDialog();
                ok = frm.Ok;
                details = frm.Details;
            }
            if (ok)
            {
                AssetType assetType = (AssetType)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveAssetType(assetType, EditType.Reactivate);
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
                    Action = $"Reactivate Asset Type: {assetType.TypeDescription}",
                    TableName = "asset_types",
                    RecordId = assetType.AssetTypeId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);

                btnSearchAssetType.PerformClick();
            }
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            _activeOnly = chkActiveOnly.Checked;
        }

        private void frmAssetTypes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnSearchAssetType.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10 && User.Instance.Role == 1)
            {
                ReactivateAssetType();
                e.SuppressKeyPress = true;
            }
        }
    }
}
