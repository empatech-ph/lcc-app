using LCC.Library;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Admin
{
    public partial class AdminDashboard : MaterialForm
    {
        private ClientLibrary oClient;
        public AdminDashboard()
        {
            InitializeComponent();
            ThemeLibrary.initMaterialDesign(this);
            this.oClient = new ClientLibrary();
            this.initLicenseData();
        }

        private async void initLicenseData()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "timestamp", UtilsLibrary.getTimestamp() }
            };

            dynamic oResult = await this.oClient.get("/api/license", oParam);
            if (oResult.success == true)
            {
                this.dt_license.DataSource = oResult.data;
                this.dt_license.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
                this.dt_license.Columns["license_product_code"].Visible = true;
                this.dt_license.Columns["license_license_key"].Visible = true;
                this.dt_license.Columns["license_owner_name"].Visible = true;
                this.dt_license.Columns["license_owner_email"].Visible = true;
                this.dt_license.Columns["license_is_active"].Visible = true;

                this.initUserData(0);

            }
        }

        private void btn_keyGenerator_Click(object sender, EventArgs e)
        {
            (new KeyGenerator()).ShowDialog();
        }

        private void btn_verifier_Click(object sender, EventArgs e)
        {
            (new KeyVerifier()).ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (oDialogResult == DialogResult.Yes)
            {
                this.Hide();
                new UserManagement.Login().Show();
            }
        }

        private void dt_material_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow oRow in this.dt_license.Rows)
            {
                oRow.Cells["license_is_active"].Value = ((oRow.Cells["is_active"].Value.ToString() == "1") ? Properties.Resources.checked_user_male_480px : Properties.Resources.denied_480px);
                (oRow.Cells["license_is_active"] as DataGridViewImageCell).ToolTipText = ((oRow.Cells["is_active"].Value.ToString() == "1") ? "Active" : "Disabled");
            }
        }

        private void dt_license_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRowIndex = e.RowIndex;
            if (iRowIndex != -1)
            {
                this.initUserData(iRowIndex);
            }
        }

        private void initUserData(int iRowIndex)
        {
            dynamic oUser = this.dt_license.Rows[iRowIndex].Cells["users"].Value;
            if (oUser.Count > 0)
            {
                this.dt_user.Rows.Clear();
                this.dt_user.DataSource = oUser;
                this.dt_user.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
                this.dt_user.Columns["user_name"].Visible = true;
                this.dt_user.Columns["user_email"].Visible = true;
                this.dt_user.Columns["user_is_active"].Visible = true;
            }
        }

        private void dt_user_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow oRow in this.dt_user.Rows)
            {
                oRow.Cells["user_is_active"].Value = ((oRow.Cells["is_active"].Value.ToString() == "1") ? Properties.Resources.checked_user_male_480px : Properties.Resources.denied_480px);
                (oRow.Cells["user_is_active"] as DataGridViewImageCell).ToolTipText = ((oRow.Cells["is_active"].Value.ToString() == "1") ? "Active" : "Disabled");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            this.btn_reload.Enabled = false;
            this.initLicenseData();
            this.btn_reload.Enabled = true;
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
