using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Editor.Forms
{
    public partial class TestSettingForm : Form
    {
        private readonly Test _test;

        public TestSettingForm(Test test = null)
        {
            _test = test;
            InitializeComponent();
            FillSubjectList();

            if (_test == null) return;

            InputTestNameTextBox.Text = _test.Name;
            SelectSubjectComboBox.SelectedItem = _test.Subject.Name;
            InputExcellentMarkTextBox.Text = _test.Marks.Excellent.ToString();
            InputGoodMarkTextBox.Text = _test.Marks.Good.ToString();
            InputSatisfactionMarkTextBox.Text = _test.Marks.Satisfaction.ToString();
        }

        private void FillSubjectList()
        {
            var subjectFileService = new SubjectFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);
            var subjects = subjectFileService.Load();
            SelectSubjectComboBox.Items.AddRange(subjects.Select(s => (object) s.Name).ToArray());
        }

        private void SaveTestSettingsButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateInputs())
            {
                var testDevidedFileService =
                    new TestDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);

                var fileUpdateActions = new List<FileUpdateAction<Test>>
                {
                    new FileUpdateAction<Test>
                    {
                        FileName = InputTestNameTextBox.Text + ".test",
                        SaveInformation = new Test
                        {
                            Name = InputTestNameTextBox.Text,
                            Marks = new Marks
                            {
                                Excellent = Convert(InputExcellentMarkTextBox.Text),
                                Good = Convert(InputGoodMarkTextBox.Text),
                                Satisfaction = Convert(InputSatisfactionMarkTextBox.Text)
                            },
                            Subject = new Subject
                            {
                                Name = (string) SelectSubjectComboBox.SelectedItem
                            }
                        },
                        Type = FileUpdateActionType.Save
                    }
                };

                if (_test != null)
                {
                    fileUpdateActions.Add(new FileUpdateAction<Test>
                    {
                        FileName = _test.Name + ".test",
                        Type = FileUpdateActionType.Remove
                    });
                }

                testDevidedFileService.Update(fileUpdateActions);

                Close();
                
                MessageBox.Show(@"Сохранение теста прошло успешно", @"Тест сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var result = int.TryParse(mark, out var intMark);
            return result && intMark <= 100 && intMark >= 0;
        }

        private static int Convert(string mark)
        {
            var isSuccess = int.TryParse(mark, out var resultValue);
            return isSuccess ? resultValue : 0;
        }
    }
}