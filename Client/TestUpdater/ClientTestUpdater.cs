using System.ComponentModel;
using Client.Services;
using Client.Services.Implementations;

namespace Client.TestUpdater
{
    public class ClientTestUpdater
    {
        private readonly IServerConnectionService _serverConnectionService;
        private readonly IClientTestFileService _clientTestFileService;

        public ClientTestUpdater(string serverId, int serverPort)
        {
            _serverConnectionService = new ServerConnectionService(serverId, serverPort);
            _clientTestFileService =
                new ClientTestFileService(ClientConfiguration.GetInstance().TestFolder, ClientConfiguration.GetInstance().ImageFolder);
        }

        public void Update(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (!_serverConnectionService.IsConnected())
            {
                return;
            }

            var state = new ClientTestUpdaterState {State = ClientTestUpdaterStates.GetInformationObjectsFromServer};
            worker.ReportProgress(0, state);

            var testInformationObjects = _serverConnectionService.GetTestInformationObjects();

            //TODO Добавить получение списка тестов на клиенте. Удалять ненужные тесты и обновлять только те тесты, которые надо

            state.State = ClientTestUpdaterStates.GetTests;
            worker.ReportProgress(0, state);

            var tests = _serverConnectionService.GetTests(testInformationObjects);

            state.State = ClientTestUpdaterStates.GetImageInfromationObjects;
            worker.ReportProgress(0, state);

            var imageInfromationObjects = _serverConnectionService.GetImageInfromationObjects();

            //TODO Добавить получение списка тестов на клиенте. Удалять ненужные изображения и обновлять только те изображения, которые надо

            state.State = ClientTestUpdaterStates.GetImages;
            worker.ReportProgress(0, state);

            var images = _serverConnectionService.GetImages(imageInfromationObjects);

            state.State = ClientTestUpdaterStates.SavingTests;
            worker.ReportProgress(0, state);

            _clientTestFileService.SaveTests(tests);

            state.State = ClientTestUpdaterStates.SavingImages;
            worker.ReportProgress(0, state);

            _clientTestFileService.SaveImages(images);
        }
    }
}