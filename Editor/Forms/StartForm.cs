using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Models;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Editor.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            SaveDirectoryFileSystemWatcher.Path = ConfigContainer.GetConfig<EditorConfig>().SaveFolder;
            DrawTestPanels();
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

        private void DrawTestPanels()
        {
            TestFlowLayoutPanel.Controls.Clear();

            var testDevidedFileService =
                new TestDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);
            var tests = testDevidedFileService.Load().Values;

            foreach (var test in tests)
            {
                var panel = CreatePanelForTest(test);
                TestFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private Panel CreatePanelForTest(Test test)
        {
            var panel = new Panel();

            var testNameLabel = new Label();
            var deleteTestButton = new Button();
            var buttonTestOpenNew = new Button();
            var settingTestButton = new Button();
            var downloadWordButton = new Button();

            panel.BackColor = SystemColors.ControlLight;
            panel.Controls.Add(testNameLabel);
            panel.Controls.Add(buttonTestOpenNew);
            panel.Controls.Add(settingTestButton);
            panel.Controls.Add(downloadWordButton);
            panel.Controls.Add(deleteTestButton);
            panel.Size = new Size(1100, 51);
            panel.Tag = test;

            testNameLabel.AutoSize = true;
            testNameLabel.Font = new Font("Century Gothic", 11.25F);
            testNameLabel.Location = new Point(3, 15);
            testNameLabel.Size = new Size(146, 20);
            testNameLabel.Text = test.Name;
            testNameLabel.TabStop = true;
            testNameLabel.TextAlign = ContentAlignment.MiddleCenter;

            buttonTestOpenNew.FlatStyle = FlatStyle.Flat;
            buttonTestOpenNew.Font = new Font("Century Gothic", 11.25F);
            buttonTestOpenNew.Location = new Point(485, 5);
            buttonTestOpenNew.Size = new Size(150, 40);
            buttonTestOpenNew.Text = @"Редактировать";
            buttonTestOpenNew.UseVisualStyleBackColor = true;
            buttonTestOpenNew.TextAlign = ContentAlignment.MiddleCenter;

            settingTestButton.FlatStyle = FlatStyle.Flat;
            settingTestButton.Font = new Font("Century Gothic", 11.25F);
            settingTestButton.Location = new Point(640, 5);
            settingTestButton.Size = new Size(140, 40);
            settingTestButton.Text = @"Параметры";
            settingTestButton.UseVisualStyleBackColor = true;
            settingTestButton.TextAlign = ContentAlignment.MiddleCenter;

            downloadWordButton.FlatStyle = FlatStyle.Flat;
            downloadWordButton.Font = new Font("Century Gothic", 11.25F);
            downloadWordButton.Location = new Point(785, 5);
            downloadWordButton.Size = new Size(150, 40);
            downloadWordButton.Text = @"Скачать в Word";
            downloadWordButton.UseVisualStyleBackColor = true;
            downloadWordButton.Enabled = true;
            downloadWordButton.TextAlign = ContentAlignment.MiddleCenter;

            deleteTestButton.FlatStyle = FlatStyle.Flat;
            deleteTestButton.Font = new Font("Century Gothic", 11.25F);
            deleteTestButton.Location = new Point(940, 5);
            deleteTestButton.Size = new Size(150, 40);
            deleteTestButton.Text = @"Удалить";
            deleteTestButton.UseVisualStyleBackColor = true;
            deleteTestButton.Enabled = true;

            buttonTestOpenNew.Click += OpenTestEditor;
            settingTestButton.Click += SettingTest;
            downloadWordButton.Click += DownloadWord;
            deleteTestButton.Click += DeleteTest;

            return panel;
        }

        private void OpenTestEditor(object sender, System.EventArgs e)
        {
            var test = (Test) ((Button) sender).Parent.Tag;
        }

        private void SettingTest(object sender, System.EventArgs e)
        {
            var test = (Test) ((Button) sender).Parent.Tag;

            var testSettingForm = new TestSettingForm(test);
            testSettingForm.Show();
        }

        private void DownloadWord(object sender, System.EventArgs e)
        {
            var test = (Test) ((Button) sender).Parent.Tag;
        }

        private void DeleteTest(object sender, System.EventArgs e)
        {
            var test = (Test) ((Button) sender).Parent.Tag;
            var testDevidedFileService =
                new TestDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);

            testDevidedFileService.Update(new List<FileUpdateAction<Test>>
            {
                new FileUpdateAction<Test>
                {
                    FileName = test.Name + ".test",
                    Type = FileUpdateActionType.Remove
                }
            });
        }

        private void SaveDirectoryFileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            DrawTestPanels();
        }

        private void SaveDirectoryFileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            DrawTestPanels();
        }

        private void SaveDirectoryFileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            DrawTestPanels();
        }
    }
}