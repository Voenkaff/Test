using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;
using Models.Test;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Client.Forms
{
    public partial class StartForm : Form
    {
        private readonly List<Subject> _subjects;
        private readonly List<Platoon> _platoons;
        private readonly List<Test> _tests;

        public StartForm()
        {
            InitializeComponent();

            var savePath = ConfigContainer.GetConfig<ClientConfig>().SaveFolder;

            _subjects = new SubjectFileService(savePath).Load();
            _platoons = new PlatoonFileService(savePath).Load();
            _tests = new TestDevidedFileService(savePath).Load().Values.ToList();

            ChoiceSubjectComboBox.Items.AddRange(_subjects.Select(subject => (object) subject.Name).OrderBy(o => o).ToArray());
            ChoicePlatoonComboBox.Items.AddRange(_platoons.OrderBy(platoon => platoon.Name).Select(platoon => (object) platoon.Name).ToArray());
        }

        private void StartTestButton_Click(object sender, System.EventArgs e)
        {
        }

        private void ShowInstractionButton_Click(object sender, System.EventArgs e)
        {
            var formInstruction = new FormInstruction();
            formInstruction.Show();
        }

        private void SettingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var formSettings = new FormSettings();
            formSettings.Show();
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