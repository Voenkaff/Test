using System.Windows.Forms;

namespace Editor.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void PlatoonToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var platoonsForm = new PlatoonsForm();
            platoonsForm.Show();
        }

        private void SubjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var subjectForm = new SubjectForm();
            subjectForm.Show();
        }

        private void SettingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var settingForm = new SettingForm();
            settingForm.Show();
        }

        private void AddTestButton_Click(object sender, System.EventArgs e)
        {
            var testSettingForm = new TestSettingForm();
            testSettingForm.Show();
        }

        private void ClearSubjectFilterButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
