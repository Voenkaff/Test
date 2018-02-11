using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Services.Configuration;

namespace Client.Forms
{
    public partial class FormSettings : Form
    {
        private readonly ClientConfig _config;

        public FormSettings()
        {
            InitializeComponent();
            _config = ConfigContainer.GetConfig<ClientConfig>();
            PortTextBox.Text = _config.ServerPort.ToString();
            IpAddressTextBox.Text = _config.ServerIp;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!IsIpValid())
            {
                MessageBox.Show(@"Ип аддресс не правильный");
                return;
            }

            if (!IsPortValid())
            {
                MessageBox.Show(@"Порт должен быть числом от 0 до 65535");
                return;
            }

            _config.ServerIp = IpAddressTextBox.Text;
            _config.ServerPort = int.Parse(PortTextBox.Text);
            
            ConfigContainer.SaveConfiguration();

            Close();
        }

        private bool IsPortValid()
        {
            int port;
            return PortTextBox.Text != null && int.TryParse(PortTextBox.Text, out port) && port > 0 && port <= 65535;
        }

        private bool IsIpValid()
        {
            var ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
            var obj = IpAddressTextBox;
            return ip.IsMatch(obj.Text);
        }
    }
}