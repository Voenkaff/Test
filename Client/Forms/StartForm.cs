using System.Windows.Forms;

namespace Client.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartTestButton_Click(object sender, System.EventArgs e)
        {

        }

        private void ShowInstractionButton_Click(object sender, System.EventArgs e)
        {

        }

        private void SettingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void UpdateTestsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            var loadingForm = new LoadingForm();
            loadingForm.Closed += (s, args) => Close();
            loadingForm.Show();
        }
        
    }
}
