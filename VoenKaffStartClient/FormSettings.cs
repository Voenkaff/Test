using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VoenKaffServer;
using VoenKaffStartClient.Senders;

namespace VoenKaffStartClient
{
    public partial class FormSettings : Form
    {
        private readonly DynamicParams _parameters;
        public FormSettings()
        {
            InitializeComponent();
            _parameters=new DynamicParams();
            Port.Text = _parameters.Get().Port.ToString();
            IpAddress.Text = _parameters.Get().Ip;
        }

        private void Port_Leave(object sender, EventArgs e)
        {
            var portValue = ((Control)sender).Text;
            int port;
            if (portValue != null && Int32.TryParse(portValue, out port) && port > 0 && port <= 65535)
            {
                _parameters.SetPort(port);
            }
            else
            {
                MessageBox.Show(@"Закрыть без сохранения результатов? 
(Чтобы сохранить результаты, войдите как преподаватель)", @"Есть несохраненные результаты!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Port.Text = "";
            }
        }

        private void IpAddress_Leave(object sender, EventArgs e)
        {
            Regex ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
            var obj = (TextBox) sender;
            if (ip.IsMatch(obj.Text))
            {
                _parameters.SetIp(obj.Text);
            }
            else
            {
                MessageBox.Show(@"Закрыть без сохранения результатов? 
(Чтобы сохранить результаты, войдите как преподаватель)", @"Есть несохраненные результаты!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (!new TestConnection().Connect())
            {
                MessageBox.Show(@"Закрыть без сохранения результатов? 
(Чтобы сохранить результаты, войдите как преподаватель)", @"Есть несохраненные результаты!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Visible = false;
        }
    }
}
