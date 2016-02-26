using System;
using System.Diagnostics;
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
            {
                contextMenuOptionCheckbox.Enabled = false;
                restartButton.AddUACIcon();
            }

            passesCount.Value = Settings.Default.PassesCount;

            #region Bind like a pro

            passesCountLabel.Text = Resources.MainForm_NumberOfPassesLabel;
            restartButton.Text = Resources.MainForm_RestartButton;
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
            Settings.Default.Save();
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
            Process.Start(new ProcessStartInfo("https://github.com/deszz/Wiper"));
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Program.RestartAsAdmin(String.Empty);
        }

        private void passesCount_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.PassesCount = (int)passesCount.Value;
        }
    }
}
