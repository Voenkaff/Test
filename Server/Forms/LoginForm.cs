using System;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!IsLoginAndPasswordValid())
            {
                MessageBox.Show(@"Пожалуйста, введите имя пользователя и пароль");
                return;
            }

            if (LoginTextBox.Text == @"admin" && PasswordTextBox.Text == @"admin")
            {
                Hide();
                var startForm = new StartForm();
                startForm.Closed += (s, args) => Close();
                startForm.Show();
            }
            else
            {
                MessageBox.Show(@"Пожалуйста, введите имя пользователя и пароль");
            }
        }

        private bool IsLoginAndPasswordValid()
        {
            return !string.IsNullOrWhiteSpace(LoginTextBox.Text) || !string.IsNullOrWhiteSpace(PasswordTextBox.Text);
        }

        //        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        //        {
        //            if (_formStart.ResultsSaver.TestsSaved == false || _formStart.ResultsSaver.TestsSaved == false)
        //            {
        //                var messageBox = MessageBox.Show(@"Закрыть без сохранения результатов? 
        //(Чтобы сохранить результаты, войдите как преподаватель)", @"Есть несохраненные результаты!",
        //                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //                if (messageBox == DialogResult.OK)
        //                {
        //                    Environment.Exit(0);
        //                }

        //                if (messageBox == DialogResult.Cancel)
        //                {
        //                    e.Cancel = true;
        //                }
        //            }
        //            else
        //            {
        //                Environment.Exit(0);
        //            }
        //        }
    }
}