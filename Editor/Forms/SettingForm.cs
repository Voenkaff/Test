using System.Windows.Forms;
using Services.Configuration;

namespace Editor.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            SavePathTextBox.Text = ConfigContainer.GetConfig<EditorConfig>().SaveFolder;
        }

        private void OpenFileDialogButton_Click(object sender, System.EventArgs e)
        {
            var result = SavePathFolderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SavePathTextBox.Text = SavePathFolderBrowserDialog.SelectedPath;
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            ConfigContainer.GetConfig<EditorConfig>().SaveFolder = SavePathTextBox.Text;
            ConfigContainer.SaveConfiguration();

            Close();

            MessageBox.Show(@"Сохранение настроек прошло успешно", @"Настройки сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
