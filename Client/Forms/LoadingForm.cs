using System;
using System.ComponentModel;
using System.Windows.Forms;
using Client.TestUpdater;

namespace Client.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void StartLoadingButton_Click(object sender, EventArgs e)
        {
            StartLoadingButton.Enabled = false;
            StartThread();
        }

        private void StartThread()
        {
            LoadingStatusLabel.Text = @"Обновление начато";

            var testUpdater = new ClientTestUpdater(ClientConfiguration.ServerIp, ClientConfiguration.ServerPort);
            LoadingTestBackgroundWorker.RunWorkerAsync(testUpdater);
        }

        private void LoadingTestBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker) sender;
            var testUpdater = (ClientTestUpdater) e.Argument;
            testUpdater.Update(worker, e);
        }

        private void LoadingTestBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingStatusLabel.Text = @"Обновление завершено";
            MessageBox.Show(e.Error != null ? $@"Ошибка: {e.Error.Message}" : @"Обновление тестов завершена");
        }

        private void LoadingTestBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var state = (ClientTestUpdaterState) e.UserState;

            switch (state.State)
            {
                case ClientTestUpdaterStates.GetInformationObjectsFromServer:
                    LoadingStatusLabel.Text = @"Загрзука информации о тестах с сервера";
                    LoadingStatusProgressBar.Value += 10;
                    break;
                case ClientTestUpdaterStates.GetTests:
                    LoadingStatusLabel.Text = @"Загрзука тестов с сервера";
                    LoadingStatusProgressBar.Value += 20;
                    break;
                case ClientTestUpdaterStates.GetImageInfromationObjects:
                    LoadingStatusLabel.Text = @"Загрзука информации о изображениях с сервера";
                    LoadingStatusProgressBar.Value += 10;
                    break;
                case ClientTestUpdaterStates.GetImages:
                    LoadingStatusLabel.Text = @"Загрзука изображений с сервера";
                    LoadingStatusProgressBar.Value += 20;
                    break;
                case ClientTestUpdaterStates.SavingTests:
                    LoadingStatusLabel.Text = @"Сохранение тестов";
                    LoadingStatusProgressBar.Value += 20;
                    break;
                case ClientTestUpdaterStates.SavingImages:
                    LoadingStatusLabel.Text = @"Сохранение изображений";
                    LoadingStatusProgressBar.Value += 20;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}