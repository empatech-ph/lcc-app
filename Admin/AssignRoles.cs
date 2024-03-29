﻿using LCC.Library;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Admin
{
    public partial class AssignRoles : MaterialForm
    {
        public RichTextBox oAssignRoles;

        public AssignRoles(string sUserEmails)
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);

            string[] aUserEmails = sUserEmails.TrimStart(',').TrimEnd(',').Split(',');
            for (int i = 0; aUserEmails.Length > i; i++)
            {
                if(aUserEmails[i] != "")
                dgv_usersToBeAdded.Rows.Add(aUserEmails[i].ToString().Split('/')[0], aUserEmails[i].ToString().Split('/')[1]);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sEmailsWithRoles = "";
            for (int i = 0; dgv_usersToBeAdded.RowCount > i; i++)
            {
                var oRowView = dgv_usersToBeAdded.Rows[i];
                if (oRowView.Cells["email"].Value != null && oRowView.Cells["role"].Value != null)
                {
                    sEmailsWithRoles += oRowView.Cells["email"].Value.ToString() + "/" + oRowView.Cells["role"].Value.ToString() + ",";
                }
            }
            this.oAssignRoles.Text = sEmailsWithRoles.Trim(',');
            this.Hide();
        }
    }
}
