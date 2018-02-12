using System;
using System.Windows.Forms;
using Server.Listener;
using Services.Configuration;

namespace Server.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            var config = ConfigContainer.GetConfig<ServerConfig>();

            ResultFolderTextBox.Text = config.ResultFolder;
            TestFolderTextBox.Text = config.TestFolder;

            IpTextBox.Text = config.ServerIp;
            PortLabelTextBox.Text = config.ServerPort.ToString();
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            if (!IsInputDataValid()) return;

            SaveConfig();

            Close();

            MessageBox.Show(@"Сохранение настроек прошло успешно", @"Настройки сохранены", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool IsInputDataValid()
        {
            //TODO Сделать валидацию введеных пользователем параметров
            return true;
        }

        private void SaveConfig()
        {
            var config = ConfigContainer.GetConfig<ServerConfig>();

            config.ResultFolder = ResultFolderTextBox.Text;
            config.TestFolder = TestFolderTextBox.Text;

            config.ServerIp = IpTextBox.Text;
            config.ServerPort = int.Parse(PortLabelTextBox.Text);

            ConfigContainer.SaveConfiguration();
            ListenerContainer.Restart();
        }
    }
}