using System.Windows.Forms;

namespace Wiper
{
    public partial class ProgressForm : Form
    {
        public string Title
        {
            get
            {
                return titleLabel.Text;
            }
            set
            {
                titleLabel.Text = value;
            }
        }
        public string Description
        {
            get
            {
                return descriptionLabel.Text;
            }
            set
            {
                descriptionLabel.Text = value;
            }
        }

        public ProgressForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int percent)
        {
            progressBar.Invoke((MethodInvoker)(() => progressBar.Value = percent));
        }
    }
}
