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
    public partial class frmBranches : frmBase
    {
        private static frmBranches _instance;
        private bool _activeOnly;

        public frmBranches()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _activeOnly = true;
        }

        public static frmBranches Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmBranches();
            }
            return _instance;
        }

        private void btnSearchBranch_Click(object sender, EventArgs e)
        {
            string description = txtBranchDescription.Text;
            QueryResult<Branch> results = new QueryResult<Branch>();
            using (AssetService assetService = new AssetService())
            {
                results = assetService.GetBranches(description, _activeOnly);
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
            dtgBranches.DataSource = results.Data;
        }

        private void ReactivateBranch()
        {
            if (dtgBranches.Rows.Count == 0)
            {
                MessageBox.Show("No hay sucursales para reactivar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgBranches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sucursal para reactivar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow selectedRow = dtgBranches.SelectedRows[0];
            if (selectedRow.Cells["endDate"].Value == null ||
                selectedRow.Cells["endDate"].Value == DBNull.Value)
            {
                MessageBox.Show("La sucursal seleccionada ya está activa", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ok;
            string details;
            using (frmAddDetails ofrm = new frmAddDetails("Reactivar Sucursal"))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
            }
            if (ok)
            {
                Branch branch = (Branch)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveBranch(branch, EditType.Reactivate);
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
                    Action = $"Reactivate Branch: {branch.BranchDescription}",
                    RecordId = branch.BranchId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                btnSearchBranch.PerformClick();
            }
        }

        private void tsButtonBranchNew_Click(object sender, EventArgs e)
        {
            bool ok;
            using (frmBranchEdit ofrm = new frmBranchEdit())
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
                btnSearchBranch.PerformClick();
        }

        private void tsButtonBranchEdit_Click(object sender, EventArgs e)
        {
            if (dtgBranches.Rows.Count == 0)
            {
                MessageBox.Show("No hay filiales para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtgBranches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgBranches.SelectedRows[0];
            Branch branch = (Branch)selectedRow.DataBoundItem;

            bool ok;
            using (frmBranchEdit ofrm = new frmBranchEdit(branch))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
            }
            if (ok)
                btnSearchBranch.PerformClick();
        }

        private void tsButtonBranchEndate_Click(object sender, EventArgs e)
        {
            if (dtgBranches.Rows.Count == 0)
            {
                MessageBox.Show("No hay filiales para finalizar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(dtgBranches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow selectedRow = dtgBranches.SelectedRows[0];
            if(selectedRow.Cells["endDate"].Value != null)
            {
                MessageBox.Show("La filial seleccionada ya está finalizada", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ok;
            string details;
            using (frmAddDetails ofrm = new frmAddDetails("Inactivar Filial"))
            {
                ofrm.ShowDialog();
                ok = ofrm.Ok;
                details = ofrm.Details;
            }
            if (ok)
            {
                Branch branch = (Branch)selectedRow.DataBoundItem;
                string result = string.Empty;
                using (AssetService service = new AssetService())
                {
                    result = service.SaveBranch(branch, EditType.Endate);
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
                    Action = $"Endate Branch: {branch.BranchDescription}",
                    RecordId = branch.BranchId.ToString(),
                    Details = details
                };
                Utilities.SaveAuditRecord(audit);
                //refresh grid
                btnSearchBranch.PerformClick();
            }
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            _activeOnly = chkActiveOnly.Checked;
        }

        private void frmBranches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnSearchBranch.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10 && User.Instance.Role == 1)
            {
                ReactivateBranch();
                e.SuppressKeyPress = true;
            }
        }
    }
}
