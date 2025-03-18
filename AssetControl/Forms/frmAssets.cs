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
    public partial class frmAssets : frmBase
    {
        private static frmAssets _instance;
        private bool _activeOnly;
        private bool _genericAsset = true;
        public frmAssets()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _activeOnly = true;
        }

        public static frmAssets Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmAssets();
            }
            return _instance;
        }

        private void btnSearchAssets_Click(object sender, EventArgs e)
        {
            AssetSearchOptions searchOptions = new AssetSearchOptions()
            {
                Description = txtAssetDescription.Text,
                AssetTag = txtAssetTag.Text,
                AssetType = Convert.ToInt32(cbAssetType.SelectedValue),
                Status = Convert.ToInt32(cbAssetStatus.SelectedValue),
                Location = Convert.ToInt32(cbAssetLocation.SelectedValue),
                Branch = Convert.ToInt32(cbAssetBranch.SelectedValue),
                ActiveOnly = _activeOnly,
                GenericAsset = _genericAsset
            };
            QueryResult<Asset> results = new QueryResult<Asset>();
            using (AssetService assetService = new AssetService())
            {
                results = assetService.GetAssets(searchOptions);
            }
            if (!string.IsNullOrEmpty(results.ErrorMessage))
            {
                MessageBox.Show($"Error: {results.ErrorMessage}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (results.Data.Count == 0)
                MessageBox.Show("No se encontraron datos", "Sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dtgAssets.DataSource = results.Data;
        }

        //methods to fill comboboxes only when needed
        private void cbAssetType_DropDown(object sender, EventArgs e)
        {
            if(cbAssetType.DataSource == null)
            {
                List<AssetType> assets = new List<AssetType>();
                using (AssetService assetService = new AssetService())
                {
                    assets = assetService.GetAssetTypesList();
                }
                if (assets.Count > 0)
                {
                    cbAssetType.DataSource = assets;
                    cbAssetType.SelectedIndex = -1;
                }
            }
        }

        private void cbAssetStatus_DropDown(object sender, EventArgs e)
        {
            if (cbAssetStatus.DataSource == null)
            {
                List<AssetStatus> statuses = new List<AssetStatus>();
                using (AssetService assetService = new AssetService())
                {
                    statuses = assetService.GetAssetStatusesList();
                }
                if (statuses.Count > 0)
                {
                    cbAssetStatus.DataSource = statuses;
                    cbAssetStatus.SelectedIndex = -1;
                }
            }
        }

        private void cbAssetLocation_DropDown(object sender, EventArgs e)
        {
            if (cbAssetLocation.DataSource == null)
            {
                List<AssetLocation> locations = new List<AssetLocation>();
                using (AssetService assetService = new AssetService())
                {
                    locations = assetService.GetLocationsList();
                }
                if (locations.Count > 0)
                {
                    cbAssetLocation.DataSource = locations;
                    cbAssetLocation.SelectedIndex = -1;
                }
            }
        }

        private void cbAssetBranch_DropDown(object sender, EventArgs e)
        {
            if (cbAssetBranch.DataSource == null)
            {
                List<Branch> branches = new List<Branch>();
                using (AssetService assetService = new AssetService())
                {
                    branches = assetService.GetBranchesList();
                }
                if (branches.Count > 0)
                {
                    cbAssetBranch.DataSource = branches;
                    cbAssetBranch.SelectedIndex = -1;
                }
            }
        }
        #region Button Events
        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            _activeOnly = chkActiveOnly.Checked;
        }

        private void chkGenericAsset_CheckedChanged(object sender, EventArgs e)
        {
            _genericAsset = chkGenericAsset.Checked;
        }

        private void btnClearAssets_Click(object sender, EventArgs e)
        {
            txtAssetDescription.Text = null;
            txtAssetTag.Text = null;
            cbAssetType.SelectedIndex = -1;
            cbAssetStatus.SelectedIndex = -1;
            cbAssetLocation.SelectedIndex = -1;
            cbAssetBranch.SelectedIndex = -1;
            chkActiveOnly.Checked = true;
            chkGenericAsset.Checked = false;
        }

        private void tsButtonNewAsset_Click(object sender, EventArgs e)
        {
            bool ok;
            using (frmAssetEdit ofrm = new frmAssetEdit())
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
                btnSearchAssets.PerformClick();
            
        }

        private void tsButtonEditAsset_Click(object sender, EventArgs e)
        {
            if (dtgAssets.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un activo para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgAssets.SelectedRows[0];
            Asset asset = (Asset)selectedRow.DataBoundItem;

            bool ok;
            using (frmAssetEdit ofrm = new frmAssetEdit(asset))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
                btnSearchAssets.PerformClick();
        }

        private void tsButtonChangeState_Click(object sender, EventArgs e)
        {
            if (dtgAssets.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un activo para cambiar estado", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgAssets.SelectedRows[0];
            Asset asset = (Asset)selectedRow.DataBoundItem;
            if (asset.EndDate != null)
            {
                MessageBox.Show("El activo seleccionado ya fue retirado\nNose puede cambiar su estado",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ok;
            string details;
            int oldStatus = asset.Status;
            int selectedId;
            using (frmAddDetails ofrm = new frmAddDetails("Cambiar Estado", true))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
                selectedId = ofrm.SelectedId;
            }
            if (oldStatus == selectedId)
            {
                MessageBox.Show("El estado seleccionado es el mismo que el actual.\nNo se guardarán los cambios",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ok)
            {
                asset.Status = selectedId;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveAsset(asset, EditType.ChangeStatus);
                }
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show($"Error: {result}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AuditRecord auditRecord = new AuditRecord()
                {
                    LogDate = DateTime.Now,
                    UserId = User.Instance.UserId,
                    Action = $"Change Asset Status: {asset.Description}",
                    RecordId = asset.Id.ToString(),
                    Details = details,
                    OldValue = oldStatus.ToString(),
                    NewValue = selectedId.ToString()
                };
                Utilities.SaveAuditRecord(auditRecord);
                //Refresh grid
                btnSearchAssets.PerformClick(); 
            }
            
        }

        private void tsButtonEndate_Click(object sender, EventArgs e)
        {
            if (dtgAssets.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un activo para retirar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dtgAssets.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value != null)
            {
                MessageBox.Show("El activo seleccionado ya fue retirado",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ok;
            string details;
            int selectedId;
            using (frmAddDetails ofrm = new frmAddDetails("Retirar Activo", true))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
                selectedId = ofrm.SelectedId;
            }
            if (ok)
            {
                Asset asset = (Asset)selectedRow.DataBoundItem;
                asset.RetirementReason = selectedId;
                asset.EndateNote = details;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveAsset(asset, EditType.Endate);
                }
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show($"Error: {result}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AuditRecord auditRecord = new AuditRecord()
                {
                    LogDate = DateTime.Now,
                    UserId = User.Instance.UserId,
                    Action = $"Endate Asset: {asset.Description}",
                    RecordId = asset.Id.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(auditRecord);
                //Refresh grid
                btnSearchAssets.PerformClick();
            }
        }

        private void tsButtonMoveAsset_Click(object sender, EventArgs e)
        {
            if(dtgAssets.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgAssets.SelectedRows[0];
            Asset asset = (Asset)selectedRow.DataBoundItem;
            if (asset.EndDate != null)
            {
                MessageBox.Show("El activo seleccionado ya fue retirado.\nNo se puede editar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int oldBranch = asset.Branch;
            bool ok;
            string details;
            int selectedId;
            using (frmAddDetails ofrm = new frmAddDetails("Mover Activo", true))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
                selectedId = ofrm.SelectedId;
            }
            if (oldBranch == selectedId)
            {
                MessageBox.Show("La filial seleccionada es la misma que la actual.\nNo se guardarán los cambios",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ok)
            {
                asset.Branch = selectedId;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveAsset(asset, EditType.Move);
                }
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show($"Error: {result}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AuditRecord auditRecord = new AuditRecord()
                {
                    LogDate = DateTime.Now,
                    UserId = User.Instance.UserId,
                    Action = $"Move Asset: {asset.Description}",
                    RecordId = asset.Id.ToString(),
                    Details = details,
                    OldValue = oldBranch.ToString(),
                    NewValue = selectedId.ToString()
                };
                Utilities.SaveAuditRecord(auditRecord);
                //Refresh grid
                btnSearchAssets.PerformClick(); 
            }
            
        }
#endregion region
        private void frmAssets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnSearchAssets.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                btnClearAssets.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cbAssetType_Enter(object sender, EventArgs e)
        {
            cbAssetType.DroppedDown = true;
        }

        private void cbAssetStatus_Enter(object sender, EventArgs e)
        {
            cbAssetStatus.DroppedDown = true;
        }

        private void cbAssetLocation_Enter(object sender, EventArgs e)
        {
            cbAssetLocation.DroppedDown = true;
        }

        private void cbAssetBranch_Enter(object sender, EventArgs e)
        {
            cbAssetBranch.DroppedDown = true;
        }
    }
}
