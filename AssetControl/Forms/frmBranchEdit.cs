using AssetControl.Classes;
using AssetControl.Exceptions;
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
    public partial class frmBranchEdit : Form
    {
        private bool _editMode;
        Branch _branch;
        private bool _ok;
        public frmBranchEdit()
        {
            InitializeComponent();
            LoadWindow(false);
            _ok = false;
        }
        internal frmBranchEdit(Branch branch)
        {
            InitializeComponent();
            _branch = branch;
            LoadWindow(true);
            _ok = false;
        }

        public bool Ok
        {
            get { return _ok; }
        }

        private void LoadWindow(bool editMode)
        {
            if (!editMode)
            {
                Text = "Crear nueva Filial";
                lblTitleBranchEdit.Location = new Point(59, 15);
                lbldObservations.Visible = true;
            }
            else
            {
                Text = "Editar Filial";
                lblTitleBranchEdit.Location = new Point(89, 15);
                lbldObservations.Visible = false;
                txtBranchId.Text = _branch.BranchId.ToString();
                txtBranchDescription.Text = _branch.BranchDescription.ToString();
            }
            _editMode = editMode;
        }

        private void btnOkBranchEdit_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch();
            branch.BranchDescription = txtBranchDescription.Text;
            branch.BranchId = _branch.BranchId;
            if (_editMode && _branch.Equals(branch))
            {                
                //nothing to do, there are no changes
                Close();
                return;
                
            }

            var validator = new Validator<Branch>();

            try
            {
                validator.FormsValidation(branch);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "BranchDescription":
                        txtBranchDescription.Focus();
                        break;
                    default:
                        break;
                }
                return;
            }

            string result;
            using (AssetService service = new AssetService())
            {
                if (!_editMode)
                    result = service.SaveBranch(branch, EditType.Insert);
                else
                    result = service.SaveBranch(branch, EditType.Update);
            }
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //save Audit log
            AuditRecord audit = new AuditRecord
            {
                LogDate = DateTime.Now,
                UserId = User.Instance.UserId,
                Action = _editMode ? "Edit Branch" : "Create Branch",
                RecordId = branch.BranchId.ToString(),
                Details = _editMode ? $"Edit Branch: {branch.BranchDescription}" : $"Create Branch: {branch.BranchDescription}",
            };
            if (_editMode)
            {
                audit.RecordId = branch.BranchId.ToString();
                audit.OldValue = this._branch.BranchDescription;
            }
                
            

            Utilities.SaveAuditRecord(audit);

            _ok = true;
            Close();
        }

        private void btnCancelBranchEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
