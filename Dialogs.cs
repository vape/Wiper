using System;
using System.Windows.Forms;

using Wiper.Properties;

namespace Wiper
{
    public static class Dialogs
    {
        public static DialogResult Question(string title, string question)
        {
            return MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult Info(string title, string info)
        {
            return MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Error(Exception e)
        {
            return MessageBox.Show(e.Message, Resources.Dialogs_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Error(string error)
        {
            return MessageBox.Show(error, Resources.Dialogs_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static ProgressForm ProgressDialog(string title, string description)
        {
            var progressForm = new ProgressForm();

            progressForm.Title = title;
            progressForm.Description = description;

            return progressForm;
        }
    }
}
