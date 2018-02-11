using System.Linq;
using System.Windows.Forms;
using Models;

namespace Editor.Forms
{
    public partial class AddFewStudentsForm : Form
    {
        private readonly PlatoonsForm _platoonsForm;
        private readonly Platoon _platoon;

        public AddFewStudentsForm(PlatoonsForm platoonsForm, Platoon platoon)
        {
            _platoonsForm = platoonsForm;
            _platoon = platoon;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            StudentsRichTextBox.Clear();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            _platoonsForm.AddStudentToListBox(StudentsRichTextBox.Lines.Select(s => (object) s).ToArray());
            _platoon.Students.AddRange(StudentsRichTextBox.Lines);

            Close();
        }

        private void StudentsRichTextBox_TextChanged(object sender, System.EventArgs e)
        {
            AddButton.Enabled = !string.IsNullOrWhiteSpace(StudentsRichTextBox.Text);
        }
    }
}