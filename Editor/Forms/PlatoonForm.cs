using System;
using System.Windows.Forms;
using Editor.Forms.Workers;
using Services.Configuration;

namespace Editor.Forms
{
    public partial class PlatoonsForm : Form
    {
        private readonly PlatoonWorker _platoonWorker;

        public PlatoonsForm()
        {
            InitializeComponent();
            _platoonWorker = new PlatoonWorker(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);

            PlatoonsListBox.Items.AddRange(_platoonWorker.GetPlatoonNamesAsObjects());
        }

        private void AddPlatoonButton_Click(object sender, EventArgs e)
        {
            AddPlatoon();
        }

        private void RemovePlatoonButton_Click(object sender, EventArgs e)
        {
            var platoonName = GetSelectedPlatoonName();

            _platoonWorker.RemovePlaton(platoonName);

            PlatoonsListBox.Items.Remove(PlatoonsListBox.SelectedItem);
            ClearPlatoonButton.Enabled = PlatoonsListBox.Items.Count != 0;
        }

        private void ClearPlatoonButton_Click(object sender, EventArgs e)
        {
            _platoonWorker.ClearPlatoon();

            PlatoonsListBox.Items.Clear();
            ClearPlatoonButton.Enabled = false;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            var platoonName = GetSelectedPlatoonName();
            var studentName = GetSelectedStudentName();

            _platoonWorker.RemoveStudent(platoonName, studentName);

            StudentsListBox.Items.Remove(StudentsListBox.SelectedItem);
            ClearPlatoonButton.Enabled = StudentsListBox.Items.Count != 0;
        }

        private void ClearStudentButton_Click(object sender, EventArgs e)
        {
            var platoonName = GetSelectedPlatoonName();

            _platoonWorker.ClearStudents(platoonName);

            StudentsListBox.Items.Clear();
            ClearStudentButton.Enabled = false;
        }

        private void SortStudentButton_Click(object sender, EventArgs e)
        {
            StudentsListBox.Sorted = true;
        }

        private void AddFewStudentButton_Click(object sender, EventArgs e)
        {
            var addFewStudentsForm = new AddFewStudentsForm(this, _platoonWorker.GetPlatoon(GetSelectedPlatoonName()));
            addFewStudentsForm.Show();
        }

        private void SavePlatoonsButton_Click(object sender, EventArgs e)
        {
            _platoonWorker.Save();

            Close();

            MessageBox.Show(@"Сохранение взоводов прошло успешно", @"Взвода сохранены", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PlatoonTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = GetPlatoonTextBoxTrimValue();
            AddPlatoonButton.Enabled = !string.IsNullOrWhiteSpace(text);
        }

        private void StudentsTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = GetStudentTextBoxTrimValue();
            AddStudentButton.Enabled = !string.IsNullOrWhiteSpace(text);
        }

        private void PlattonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isExistsSelectedPlatoon = PlatoonsListBox.SelectedItem != null;

            RemovePlatoonButton.Enabled = isExistsSelectedPlatoon;
            AddFewStudentButton.Enabled = isExistsSelectedPlatoon;

            StudentsTextBox.Enabled = isExistsSelectedPlatoon;
            StudentsListBox.Enabled = isExistsSelectedPlatoon;

            if (!isExistsSelectedPlatoon)
            {
                StudentsTextBox.Text = "";
            }

            StudentsListBox.Items.Clear();

            var platoonName = GetSelectedPlatoonName();
            var students = _platoonWorker.GetPlatoonStudentNamesAsObjects(platoonName);

            StudentsListBox.Items.AddRange(students);
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isExistsSelectedStudent = StudentsListBox.SelectedItem != null;

            RemoveStudentButton.Enabled = isExistsSelectedStudent;
        }
        
        private void PlatoonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsEnterButton(e.KeyChar))
            {
                AddPlatoon();
            }
        }

        private void StudentsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsEnterButton(e.KeyChar))
            {
                AddStudent();
            }
        }

        private void AddPlatoon()
        {
            var platoonName = GetPlatoonTextBoxTrimValue();

            if (PlatoonsListBox.Items.Contains(platoonName))
            {
                MessageBox.Show(@"Такой взвод уже существует!", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                PlatoonTextBox.Clear();
                return;
            }

            _platoonWorker.AddPlatoon(platoonName);

            PlatoonsListBox.Items.Add(platoonName);
            PlatoonTextBox.Clear();
            ClearPlatoonButton.Enabled = true;
        }
        
        private void AddStudent()
        {
            var studentName = GetStudentTextBoxTrimValue();
            var platoonName = GetSelectedPlatoonName();

            _platoonWorker.AddStudentInPlatoon(platoonName, studentName);

            StudentsListBox.Items.Add(studentName);
            StudentsTextBox.Clear();

            ClearStudentButton.Enabled = true;
        }

        private string GetStudentTextBoxTrimValue()
        {
            return StudentsTextBox.Text.Trim();
        }

        private string GetPlatoonTextBoxTrimValue()
        {
            return PlatoonTextBox.Text.Trim();
        }

        private string GetSelectedPlatoonName()
        {
            return (string) PlatoonsListBox.SelectedItem;
        }

        private string GetSelectedStudentName()
        {
            return (string) StudentsListBox.SelectedItem;
        }

        private static bool IsEnterButton(char key)
        {
            return key == '\r';
        }

        public void AddStudentToListBox(object[] item)
        {
            StudentsListBox.Items.AddRange(item);
        }
    }
}