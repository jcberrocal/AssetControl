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
    public partial class frmLocationEdit : Form
    {
        private bool _editMode;
        AssetLocation location;
        private bool _ok;
        public frmLocationEdit()
        {
            InitializeComponent();
            LoadForm(false);
        }
        internal frmLocationEdit(AssetLocation location)
        {
            InitializeComponent();
            this.location = location;
            LoadForm(true);
        }

        public bool Ok
        {
            get { return _ok; }
        }

        private void LoadForm(bool editMode)
        {
            if (!editMode)
            {
                Text = "Crear Ubicación";
                lblTitleLocationEdit.Location = new Point(41, 15);
                lblObservations.Visible = true;
            }
            else
            {
                Text = "Editar Ubicación";
                lblTitleLocationEdit.Text = "Editar Ubicación";
                lblTitleLocationEdit.Location = new Point(71, 15);
                lblObservations.Visible = false;
                txtLocationId.Text = location.AssetLocationId.ToString();
                txtLocationDescription.Text = location.LocationDescription.ToString();
            }
            this._editMode = editMode;
            _ok = false;
        }

        private void btnOkLocationEdit_Click(object sender, EventArgs e)
        {
            AssetLocation location = new AssetLocation();
            location.LocationDescription = txtLocationDescription.Text;
            if (_editMode)
            {
                location.AssetLocationId = this.location.AssetLocationId;
                if (this.location.Equals(location))
                {
                    //do nothing, there are no changes
                    Close();
                    return;
                }
            }
            var validator = new Validator<AssetLocation>();

            try
            {
                validator.FormsValidation(location);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (ex.PropertyName)
                {
                    case "LocationDescription":
                        txtLocationDescription.Focus();
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
                    result = service.SaveLocation(location, EditType.Insert);
                }
                else
                {
                    result = service.SaveLocation(location, EditType.Update);
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
                Action = _editMode ? "Editar Ubicación" : "Crear nueva Ubicación",
                TableName = "asset_locations",
                NewValue = location.LocationDescription
            };
            if (_editMode)
            {
                audit.RecordId = location.AssetLocationId.ToString();
                audit.OldValue = this.location.LocationDescription;
            }

            Utilities.SaveAuditRecord(audit);
            _ok = true;
            Close();
        }

        private void btnCancelLocationEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLocationEdit_KeyDown(object sender, KeyEventArgs e)
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
