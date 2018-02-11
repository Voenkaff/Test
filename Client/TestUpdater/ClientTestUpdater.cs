using System.ComponentModel;
using System.Linq;
using Client.Services;
using Client.Services.Implementations;
using Models.Test;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Client.TestUpdater
{
    public class ClientTestUpdater
    {
        private readonly IServerConnectionService _serverConnectionService;
        private readonly IClientTestFileService _clientTestFileService;
        private readonly SubjectFileService _subjectFileService;
        private readonly PlatoonFileService _platoonFileService;

        public ClientTestUpdater(string serverId, int serverPort)
        {
            _serverConnectionService = new ServerConnectionService(serverId, serverPort);

            _subjectFileService = new SubjectFileService(ConfigContainer.GetConfig<ClientConfig>().SaveFolder);
            _platoonFileService = new PlatoonFileService(ConfigContainer.GetConfig<ClientConfig>().SaveFolder);

            var config = ConfigContainer.GetConfig<ClientConfig>();

            _clientTestFileService =
                new ClientTestFileService(config.TestFolder, config.ImageFolder);
        }

        public void Update(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (!_serverConnectionService.IsConnected())
            {
                return;
            }

            var platoons = _serverConnectionService.GetPlatoons();
            _platoonFileService.Update(platoons);

            var subjects = _serverConnectionService.GetSubjects();
            _subjectFileService.Update(subjects);

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


            var saveFolder = ConfigContainer.GetConfig<ClientConfig>().SaveFolder;
            var testDevidedFileService = new TestDevidedFileService(saveFolder);
            testDevidedFileService.Update(tests.Select(pair => new FileUpdateAction<Test>
            {
                FileName = pair.Key,
                SaveInformation = pair.Value,
                Type = FileUpdateActionType.Save
            }).ToList());

            state.State = ClientTestUpdaterStates.SavingImages;
            worker.ReportProgress(0, state);
            
            var imageDevidedFileService = new ImageDevidedFileService(saveFolder);
            imageDevidedFileService.Update(images.Select(pair => new FileUpdateAction<byte[]>
            {
                FileName = pair.Key,
                SaveInformation = pair.Value,
                Type = FileUpdateActionType.Save
            }).ToList());
        }
    }
}