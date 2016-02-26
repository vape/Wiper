using System.Windows.Forms;

namespace Wiper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.restartButton = new System.Windows.Forms.Button();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.contextMenuOptionCheckbox = new System.Windows.Forms.CheckBox();
            this.passesCountLabel = new System.Windows.Forms.Label();
            this.passesCount = new System.Windows.Forms.NumericUpDown();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passesCount)).BeginInit();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(188, 136);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(269, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // githubLink
            // 
            this.githubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(142, 141);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(40, 13);
            this.githubLink.TabIndex = 3;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restartButton.Location = new System.Drawing.Point(12, 136);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(113, 23);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.passesCount);
            this.settingsTab.Controls.Add(this.passesCountLabel);
            this.settingsTab.Controls.Add(this.contextMenuOptionCheckbox);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(324, 92);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // contextMenuOptionCheckbox
            // 
            this.contextMenuOptionCheckbox.AutoSize = true;
            this.contextMenuOptionCheckbox.Location = new System.Drawing.Point(6, 6);
            this.contextMenuOptionCheckbox.Name = "contextMenuOptionCheckbox";
            this.contextMenuOptionCheckbox.Size = new System.Drawing.Size(203, 17);
            this.contextMenuOptionCheckbox.TabIndex = 1;
            this.contextMenuOptionCheckbox.Text = "Show option in explorer context menu";
            this.contextMenuOptionCheckbox.UseVisualStyleBackColor = true;
            this.contextMenuOptionCheckbox.CheckedChanged += new System.EventHandler(this.contextMenuOptionCheckbox_CheckedChanged);
            // 
            // passesCountLabel
            // 
            this.passesCountLabel.AutoSize = true;
            this.passesCountLabel.Location = new System.Drawing.Point(7, 30);
            this.passesCountLabel.Name = "passesCountLabel";
            this.passesCountLabel.Size = new System.Drawing.Size(92, 13);
            this.passesCountLabel.TabIndex = 2;
            this.passesCountLabel.Text = "Number of passes";
            // 
            // passesCount
            // 
            this.passesCount.Location = new System.Drawing.Point(10, 47);
            this.passesCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.passesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passesCount.Name = "passesCount";
            this.passesCount.Size = new System.Drawing.Size(120, 20);
            this.passesCount.TabIndex = 3;
            this.passesCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.passesCount.ValueChanged += new System.EventHandler(this.passesCount_ValueChanged);
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.settingsTab);
            this.mainTabs.Location = new System.Drawing.Point(12, 12);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(332, 118);
            this.mainTabs.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(356, 171);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.mainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiper";
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passesCount)).EndInit();
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private LinkLabel githubLink;
        private Button restartButton;
        private TabPage settingsTab;
        private NumericUpDown passesCount;
        private Label passesCountLabel;
        private CheckBox contextMenuOptionCheckbox;
        private TabControl mainTabs;
    }
}

