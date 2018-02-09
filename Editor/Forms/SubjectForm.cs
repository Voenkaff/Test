using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;
using Services.Services.Implementations;

namespace Editor.Forms
{
    public partial class SubjectForm : Form
    {
        private readonly SubjectFileService _subjectFileService;

        public SubjectForm()
        {
            InitializeComponent();
            _subjectFileService = new SubjectFileService(EditorConfiguration.GetInstance().SaveFolder);
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            var subjects = _subjectFileService.Load();

            if (subjects.Any())
            {
                SubjectListBox.Items.AddRange(subjects.Select(subject => (object) subject.Name).ToArray());
                ClearSubjectButton.Enabled = true;
            }
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectListBox.Items.Add(AddSubjectTextBox.Text.Trim());

            AddSubjectTextBox.Clear();

            ClearSubjectButton.Enabled = true;
        }

        private void RemoveSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectListBox.Items.Remove(SubjectListBox.SelectedItem);
            ClearSubjectButton.Enabled = SubjectListBox.Items.Count != 0;
        }

        private void ClearSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectListBox.Items.Clear();
            ClearSubjectButton.Enabled = false;
        }

        private void SaveSubjectButton_Click(object sender, EventArgs e)
        {
            var subjects = new List<Subject>();

            foreach (var item in SubjectListBox.Items)
            {
                subjects.Add(new Subject
                {
                    Name = (string) item
                });
            }

            _subjectFileService.Update(subjects);

            Close();



            MessageBox.Show(@"Сохранение предметов прошло успешно", @"Предметы сохранены", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AddSubjectTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = ((TextBox) sender).Text;
            AddSubjectButton.Enabled = !string.IsNullOrWhiteSpace(text);
        }

        private void SubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveSubjectButton.Enabled = ((ListBox) sender).SelectedItem != null;
        }
    }
}