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
    public partial class frmAddDetails : Form
    {
        string _title;
        bool _ok = false;
        bool _enableCombo;
        string _details;
        int _selectedId;
        public frmAddDetails(string title, bool enableCombo = false)
        {
            InitializeComponent();
            _title = title;
            _enableCombo = enableCombo;
            LoadWindow();
        }

        public bool Ok
        {
            get { return _ok; }
        }

        public string Details
        {
            get { return _details; }
        }

        public int SelectedId
        {
            get { return _selectedId; }
        }

        private void LoadWindow()
        {
            lblTitleAddDetails.Text = _title;
            if (_enableCombo)
            {
                lblComboTitle.Visible = true;
                cbOptions.Visible = true;                
                LoadCombo();
            }
        }

        private void LoadCombo()
        {
            switch (_title)
            {
                case "Retirar Activo":
                    lblComboTitle.Text = "Razón Retiro";
                    List<RetirementReason> retirementReasons = new List<RetirementReason>();
                    using (AssetService service = new AssetService())
                    {
                        retirementReasons = service.GetRetirementReasonsList();
                    }
                    cbOptions.DataSource = retirementReasons;
                    cbOptions.DisplayMember = "ReasonDescription";
                    cbOptions.ValueMember = "RetirementReasonId";
                    cbOptions.SelectedIndex = -1;
                    break;

                case "Cambiar Estado":
                    lblComboTitle.Text = "Nuevo Estado";
                    List<AssetStatus> statuses = new List<AssetStatus>();
                    using (AssetService service = new AssetService())
                    {
                        statuses = service.GetAssetStatusesList();
                    }
                    cbOptions.DataSource = statuses;
                    cbOptions.DisplayMember = "StatusDescription";
                    cbOptions.ValueMember = "Status";
                    cbOptions.SelectedIndex = -1;
                    break;

                case "Mover Activo":
                    lblComboTitle.Text = "Nueva Filial";
                    List<Branch> branches = new List<Branch>();
                    using (AssetService service = new AssetService())
                    {
                        branches = service.GetBranchesList();
                    }
                    cbOptions.DataSource = branches;
                    cbOptions.DisplayMember = "BranchDescription";
                    cbOptions.ValueMember = "BranchId";
                    cbOptions.SelectedIndex = -1;
                    break;
            }
            
        }

        private void btnSaveAddDetails_Click(object sender, EventArgs e)
        {
            _details = txtDetails.Text.Trim();
            if (string.IsNullOrEmpty(_details))
            {
                MessageBox.Show("Debe indicar un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDetails.Focus();
                return;
            }
            if (_enableCombo)
            {
                _selectedId = Convert.ToInt32(cbOptions.SelectedValue);
                if (_selectedId == 0)
                {
                    MessageBox.Show("Debe seleccionar una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    cbOptions.Focus();
                    return;
                }
            }
            _ok = true;
            Close();
        }

        private void frmAddDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
