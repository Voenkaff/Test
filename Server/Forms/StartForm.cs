using System.Windows.Forms;

namespace Server.Forms
{
    public partial class StartForm : Form
    {
        //private delegate void StringArgReturningVoidDelegate(string text);

        //private SettingForm _settings;

        //public ResultsSaver ResultsSaver;

        public StartForm()
      {
            InitializeComponent();
        //    ResultInitializer();

        //    ResultsSaver = new ResultsSaver(GridResultTest, ResultDataGridView);

      }

        private void SettingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var settingForm = new SettingForm();
            settingForm.Show();
        }

        //private void Initialize()
        //{
        //    var json = File.ReadAllText(Resources.ResultsData);
        //    AddResult(json);
        //}

        //private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (_settings == null || _settings.IsDisposed)
        //    {
        //        _settings = new SettingForm();
        //    }

        //    _settings.Visible = true;
        //}

        //public void AddResult(string result)
        //{
        //    if (GridResultTest.InvokeRequired)
        //    {
        //        StringArgReturningVoidDelegate d = AddResult;
        //        Invoke(d, result);
        //    }
        //    else
        //    {
        //        var resultObj = JsonConvert.DeserializeObject<Result>(result);
        //        if (resultObj.ResultType == "Экзамен")
        //        {
        //            GridResultTest.Rows.Add(
        //                resultObj.Course,
        //                resultObj.TestName,
        //                resultObj.Platoon,
        //                resultObj.StudentName,
        //                resultObj.Mark,
        //                resultObj.Timestamp
        //            );
        //            ResultsSaver.TestsSaved = false;
        //        }

        //        if (resultObj.ResultType == "Тренировка")
        //        {
        //            ResultDataGridView.Rows.Add(
        //                resultObj.Course,
        //                resultObj.TestName,
        //                resultObj.Platoon,
        //                resultObj.StudentName,
        //                resultObj.Mark,
        //                resultObj.Timestamp
        //            );
        //            ResultsSaver.StudySaved = false;
        //        }
        //    }
        //}

        //private void UpdateResults()
        //{
        //    var results = new List<Result>();
        //    foreach (DataGridViewRow row in ResultDataGridView.Rows)
        //    {
        //        if (row.Cells[2].Value != null)
        //        {
        //            results.Add(new Result
        //            {
        //                ResultType = "Тренировка",
        //                Mark = row.Cells[4].Value.ToString(),
        //                Platoon = row.Cells[2].Value.ToString(),
        //                StudentName = row.Cells[3].Value.ToString(),
        //                TestName = row.Cells[1].Value.ToString(),
        //                Timestamp = DateTime.Parse(row.Cells[5].Value.ToString()),
        //                Course = row.Cells[0].Value.ToString()
        //            });
        //        }
        //    }

        //    foreach (DataGridViewRow row in GridResultTest.Rows)
        //    {
        //        if (row.Cells[2].Value != null)
        //        {
        //            results.Add(new Result
        //            {
        //                ResultType = "Экзамен",
        //                Mark = row.Cells[4].Value.ToString(),
        //                Platoon = row.Cells[2].Value.ToString(),
        //                StudentName = row.Cells[3].Value.ToString(),
        //                TestName = row.Cells[1].Value.ToString(),
        //                Timestamp = DateTime.Parse(row.Cells[5].Value.ToString()),
        //                Course = row.Cells[0].Value.ToString()
        //            });
        //        }
        //    }

        //    File.WriteAllText(Resources.ResultsData, JsonConvert.SerializeObject(results));
        //}

        //private void GridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //}

        //private void ResultInitializer()
        //{
        //    if (File.Exists(Resources.ResultsData) && File.ReadAllText(Resources.ResultsData) != "")
        //    {
        //        var json = File.ReadAllText(Resources.ResultsData);
        //        var results = JsonConvert.DeserializeObject<List<Result>>(json);
        //        foreach (var result in results)
        //        {
        //            if (result.ResultType == "Экзамен")
        //            {
        //                GridResultTest.Rows.Add(
        //                    result.Course,
        //                    result.TestName,
        //                    result.Platoon,
        //                    result.StudentName,
        //                    result.Mark,
        //                    result.Timestamp
        //                );
        //            }

        //            if (result.ResultType == "Тренировка")
        //            {
        //                ResultDataGridView.Rows.Add(
        //                    result.Course,
        //                    result.TestName,
        //                    result.Platoon,
        //                    result.StudentName,
        //                    result.Mark,
        //                    result.Timestamp
        //                );
        //            }
        //        }
        //    }

        //    UpdateResults();
        //}

        //private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    var loginForm = new LoginForm();
        //    loginForm.Closed += (s, args) => Close();
        //    loginForm.Show();
        //}

        //private void тестированиеToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ResultsSaver._typeRes = "Тестирование";
        //    ResultsSaver.SaveResults(ResultsSaver._testsTable);
        //    ResultsSaver.TestsSaved = true;
        //}

        //private void обучениеToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ResultsSaver._typeRes = "Обучение";
        //    ResultsSaver.SaveResults(ResultsSaver._studyTable);
        //    ResultsSaver.StudySaved = true;
        //}

        //private void тестированиеИОбучениеToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //WordSaver.createDoc(this, 2);
        //}

        //private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    try
        //    {
        //        UpdateResults();
        //        if (ResultsSaver.TestsSaved == false)
        //        {
        //            //var messageBox = MessageBox.Show("Есть несохраненные результаты ТЕСТИРОВАНИЯ! Сохранить их перед закрытием?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //            //if (messageBox == DialogResult.Yes)
        //            {
        //                ResultsSaver._typeRes = "Тестирование";
        //                ResultsSaver.SaveResults(ResultsSaver._testsTable);
        //                ResultsSaver.TestsSaved = true;
        //            }
        //        }

        //        if (ResultsSaver.StudySaved == false)
        //        {
        //            //var messageBox = MessageBox.Show("Есть несохраненные результаты ОБУЧЕНИЯ! Сохранить их перед закрытием?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //            //if (messageBox == DialogResult.Yes)
        //            {
        //                ResultsSaver._typeRes = "Обучение";
        //                ResultsSaver.SaveResults(ResultsSaver._studyTable);
        //                ResultsSaver.StudySaved = true;
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message, @"Есть несохраненные результаты!", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }

        //    Environment.Exit(0);
        //}
    }
}