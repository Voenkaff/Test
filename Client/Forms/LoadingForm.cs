using System;
using System.ComponentModel;
using System.Windows.Forms;
using Client.TestUpdater;
using Services.Configuration;

namespace Client.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            StartThread();
        }

        private void StartThread()
        {
            LoadingStatusLabel.Text = @"Ожидание подключения";

            var configuration = ConfigContainer.GetConfig<ClientConfig>();

            var testUpdater = new ClientTestUpdater(configuration.ServerIp, configuration.ServerPort);
            LoadingTestBackgroundWorker.RunWorkerAsync(testUpdater);
        }

        private void LoadingTestBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker) sender;
            var testUpdater = (ClientTestUpdater) e.Argument;
            testUpdater.Update(worker, e);
        }

        private void LoadingTestBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Hide();
            var startForm = new StartForm();
            startForm.Closed += (s, args) => Close();
            startForm.Show();
        }

        private void LoadingTestBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var state = (ClientTestUpdaterState) e.UserState;

            switch (state.State)
            {
                case ClientTestUpdaterStates.GetInformationObjectsFromServer:
                    LoadingStatusLabel.Text = @"Загрзука информации о тестах с сервера";
                    LoadingStatusProgressBar.Value = 10;
                    break;
                case ClientTestUpdaterStates.GetTests:
                    LoadingStatusLabel.Text = @"Загрзука тестов с сервера";
                    LoadingStatusProgressBar.Value = 30;
                    break;
                case ClientTestUpdaterStates.GetImageInfromationObjects:
                    LoadingStatusLabel.Text = @"Загрзука информации о изображениях с сервера";
                    LoadingStatusProgressBar.Value = 40;
                    break;
                case ClientTestUpdaterStates.GetImages:
                    LoadingStatusLabel.Text = @"Загрзука изображений с сервера";
                    LoadingStatusProgressBar.Value = 60;
                    break;
                case ClientTestUpdaterStates.SavingTests:
                    LoadingStatusLabel.Text = @"Сохранение тестов";
                    LoadingStatusProgressBar.Value = 80;
                    break;
                case ClientTestUpdaterStates.SavingImages:
                    LoadingStatusLabel.Text = @"Сохранение изображений";
                    LoadingStatusProgressBar.Value = 100;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}