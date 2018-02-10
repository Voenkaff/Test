using System.Linq;
using System.Windows.Forms;
using Services.Services.Implementations.FileServices;

namespace Editor.Forms
{
    public partial class TestSettingForm : Form
    {
        public TestSettingForm()
        {
            InitializeComponent();
            FillSubjectList();
        }

        private void FillSubjectList()
        {
            var configuration = EditorConfiguration.GetInstance();
            var subjectFileService = new SubjectFileService(configuration.SaveFolder);
            var subjects = subjectFileService.Load();
            SelectSubjectComboBox.Items.AddRange(subjects.Select(s => (object) s.Name).ToArray());
        }

        private void SaveTestSettingsButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateInputs())
            {

            }
            else
            {
                MessageBox.Show(@"Ввод не валидный");
            }
        }

        private bool ValidateInputs()
        {
            return IsTestNameValid() && IsSelectedSubjectValid() && IsExecelentMarkValid() && IsGoodMarkValid() &&
                   IsSatisfactionMarkValid() && IsExcellentMarkMoreThatGoodMark() &&
                   IsGoodMarkMoreThatSatisfactionMark();
        }

        private bool IsTestNameValid()
        {
            return InputTestNameTextBox.Text.Length > 3;
        }

        private bool IsSelectedSubjectValid()
        {
            return SelectSubjectComboBox.SelectedItem != null;
        }

        private bool IsExecelentMarkValid()
        {
            return IsMarkValid(InputExcellentMarkTextBox.Text);
        }

        private bool IsGoodMarkValid()
        {
            return IsMarkValid(InputExcellentMarkTextBox.Text);
        }

        private bool IsSatisfactionMarkValid()
        {
            return IsMarkValid(InputExcellentMarkTextBox.Text);
        }

        private bool IsExcellentMarkMoreThatGoodMark()
        {
            var excellentMark = int.Parse(InputExcellentMarkTextBox.Text);
            var goodMark = int.Parse(InputGoodMarkTextBox.Text);
            return excellentMark > goodMark;
        }

        private bool IsGoodMarkMoreThatSatisfactionMark()
        {
            var goodMark = int.Parse(InputGoodMarkTextBox.Text);
            var satisfactionMark = int.Parse(InputSatisfactionMarkTextBox.Text);
            return goodMark > satisfactionMark;
        }

        private static bool IsMarkValid(string mark)
        {
            int intMark;

            var result = int.TryParse(mark, out intMark);

            return result && intMark <= 100 && intMark >= 0;
        }
    }
}