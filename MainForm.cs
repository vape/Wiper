using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wiper.Library;
using Wiper.Properties;

namespace Wiper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            contextMenuOptionCheckbox.Checked = Program.ContextOptionEnabled;

            if (!Program.HasAdminPrivelegies)
                contextMenuOptionCheckbox.Enabled = false;

            #region Bind like a pro

            okButton.Text = Resources.MainForm_OKButton;
            cancelButton.Text = Resources.MainForm_CancelButton;
            settingsTab.Text = Resources.MainForm_SettingTabTitle;
            contextMenuOptionCheckbox.Text = Resources.MainForm_ContextOptionCheckboxText;

            #endregion
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuOptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (contextMenuOptionCheckbox.Checked)
                Program.EnableContextOption();
            else
                Program.DisableContextOption();

            contextMenuOptionCheckbox.Checked = Program.ContextOptionEnabled;
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
