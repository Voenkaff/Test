using System;
using System.Windows.Forms;
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
            if (IsInputDataValid())
            {
                SaveConfig();

                Close();
                
                MessageBox.Show(@"Сохранение настроек прошло успешно", @"Настройки сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        }

        //        private void close_Click(object sender, EventArgs e)
        //        {
        //            Visible = false;
        //        }

        //        private void Port_Leave(object sender, EventArgs e)
        //        {
        //            var portValue = ((Control)sender).Text;
        //            int port;
        //            if (portValue != null && Int32.TryParse(portValue, out port) && port > 0 && port <= 65535)
        //            {
        //                _parameters.SetPort(port);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Неверно задан порт!", "Неправильное значение порта", MessageBoxButtons.OK);
        //                PortLabelTextBox.Text = "";
        //            }

        //        }

        //        private void TestDirectory_Leave(object sender, EventArgs e)
        //        {
        //            var testDirectoryValue = ((Control)sender).Text;
        //            if (Directory.Exists(testDirectoryValue))
        //            {
        //                _parameters.SetTestPath(testDirectoryValue);
        //            }
        //            else
        //            {
        //                var result = MessageBox.Show("Такой директории не существует, создать?", "Директория не существует", MessageBoxButtons.YesNo);

        //                if(result == DialogResult.Yes)
        //                {
        //                    try
        //                    {
        //                        Directory.CreateDirectory(testDirectoryValue);
        //                        if (!Directory.Exists(testDirectoryValue))
        //                        {
        //                            throw new Exception();
        //                        }
        //                    }
        //                    catch (Exception)
        //                    {
        //                        MessageBox.Show("Не удалось создать директорию", "Не удалось создать директорию",
        //                            MessageBoxButtons.OK);
        //                        ((Control)sender).Text = "";
        //                    }
        //                }
        //                else
        //                {
        //                    ((Control) sender).Text = "";
        //                }
        //            }
        //        }

        //        private void resultsDirectory_Leave(object sender, EventArgs e)
        //        {
        //            var resultsDirectoryValue = ((Control)sender).Text;
        //            if (Directory.Exists(resultsDirectoryValue))
        //            {
        //                _parameters.SetResultsPath(resultsDirectoryValue);
        //            }
        //            else
        //            {
        //                var result = MessageBox.Show("Такой директории не существует, создать?", "Директория не существует", MessageBoxButtons.YesNo);

        //                if (result == DialogResult.Yes)
        //                {
        //                    try
        //                    {
        //                        //Главная папка
        //                        Directory.CreateDirectory(resultsDirectoryValue);

        //                        if (!Directory.Exists(resultsDirectoryValue))
        //                        {
        //                            throw new Exception();
        //                        }
        //                    }
        //                    catch (Exception)
        //                    {
        //                        MessageBox.Show("Не удалось создать директорию", "Не удалось создать директорию", MessageBoxButtons.OK);
        //                        ((Control)sender).Text = "";
        //                    }
        //                }
        //                else
        //                {
        //                    ((Control)sender).Text = "";
        //                }
        //            }
        //        }

        //        private void IpAddress_Leave(object sender, EventArgs e)
        //        {
        //            Regex ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
        //            var obj = (TextBox)sender;
        //            if (ip.IsMatch(obj.Text))
        //            {
        //                _parameters.SetIp(obj.Text);
        //            }
        //            else
        //            {
        //                MessageBox.Show(@"Закрыть без сохранения результатов? 
        //(Чтобы сохранить результаты, войдите как преподаватель)", @"Есть несохраненные результаты!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }

        //        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        //        {

        //        }
    }
}