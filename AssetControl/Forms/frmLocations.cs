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
    public partial class frmLocations : frmBase
    {
        private static frmLocations _instance;
        private bool _activeOnly;

        public frmLocations()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _activeOnly = true;
            LoadForm();
        }

        public static frmLocations Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmLocations();
            }
            return _instance;
        }

        private void LoadForm()
        {
            if (User.Instance.Role != 1)
            {
                chkActiveOnly.Enabled = false;
                tsButtonLocationEndate.Enabled = false;
            }
            if (User.Instance.Role == 3)
            {
                tsButtonLocationEdit.Enabled = false;
                tsButtonLocationNew.Enabled = false;
            }
            txtLocationDescription.Focus();
        }

        private void btnSearchLocations_Click(object sender, EventArgs e)
        {
            string description = txtLocationDescription.Text;
            QueryResult<AssetLocation> results = new QueryResult<AssetLocation>();
            using(AssetService service = new AssetService())
            {
                results = service.GetLocations(description, _activeOnly);
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
            dtgLocation.DataSource = results.Data;
        }

        private void tsButtonLocationNew_Click(object sender, EventArgs e)
        {
            bool ok;
            using (frmLocationEdit frm = new frmLocationEdit())
            {
                frm.ShowDialog();
                ok = frm.Ok;
            }
            if (ok)
            {
                btnSearchLocations.PerformClick();
            }
        }

        private void tsButtonLocationEdit_Click(object sender, EventArgs e)
        {
            if (dtgLocation.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dtgLocation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dtgLocation.SelectedRows[0];
            AssetLocation location = (AssetLocation)selectedRow.DataBoundItem;

            bool ok;
            using (frmLocationEdit frm = new frmLocationEdit(location))
            {
                frm.ShowDialog();
                ok = frm.Ok;
            }
            if (ok)
            {
                btnSearchLocations.PerformClick();
            }
        }

        private void tsButtonLocationEndate_Click(object sender, EventArgs e)
        {
            if(dtgLocation.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgLocation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dtgLocation.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value != null ||
                selectedRow.Cells["endDate"].Value != DBNull.Value)
            {
                MessageBox.Show("No es posible finalizar el registro, \nya se encuentra finalizado",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ok;
            string details;
            using (frmAddDetails frm = new frmAddDetails("Inactivar Ubicación"))
            {
                frm.ShowDialog();
                ok = frm.Ok;
                details = frm.Details;
            }
            if (ok)
            {
                AssetLocation location = (AssetLocation)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveLocation(location, EditType.Endate);
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
                    TableName = "asset_locations",
                    Action = $"Endate Location: {location.LocationDescription}",
                    RecordId = location.AssetLocationId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                //refresh grid
                btnSearchLocations.PerformClick();
            }
        }

        private void ReactivateLocation()
        {
            if (dtgLocation.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgLocation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dtgLocation.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value == null ||
                selectedRow.Cells["endDate"].Value == DBNull.Value)
            {
                MessageBox.Show("No es posible reactivar el registro, \nya se encuentra activo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ok;
            string details;
            using (frmAddDetails frm = new frmAddDetails("Reactivar Ubicación"))
            {
                frm.ShowDialog();
                ok = frm.Ok;
                details = frm.Details;
            }
            if (ok)
            {
                AssetLocation location = (AssetLocation)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveLocation(location, EditType.Reactivate);
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
                    TableName = "asset_locations",
                    Action = $"Reactivar Ubicación: {location.LocationDescription}",
                    RecordId = location.AssetLocationId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                //refresh grid
                btnSearchLocations.PerformClick();
            }
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            _activeOnly = chkActiveOnly.Checked;
        }

        private void frmLocations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnSearchLocations.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10)
            {
                ReactivateLocation();
                e.SuppressKeyPress = true;
            }
        }
    }
}
