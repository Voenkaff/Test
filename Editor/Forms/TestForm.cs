using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Models.Test;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Editor.Forms
{
    public partial class TestForm : Form
    {
        private readonly Test _test;

        public TestForm(Test test)
        {
            _test = test;

            InitializeComponent();

            AddFirstTaskToTestIfIsTestEmpty(_test);

            DrawTasksLink();
            DrawTestCreatorPanel(_test.Tasks.FirstOrDefault());
        }

        private static void AddFirstTaskToTestIfIsTestEmpty(Test test)
        {
            if (!test.Tasks.Any())
            {
                test.Tasks.Add(new Task
                {
                    Name = "Задание №1"
                });
            }
        }

        private void CreateTaskButton_Click(object sender, System.EventArgs e)
        {
            var task = new Task
            {
                Name = $"Задание №{_test.Tasks.Count + 1}"
            };

            _test.Tasks.Add(task);

            DrawTasksLink();
        }

        private void InsertTextButton_Click(object sender, System.EventArgs e)
        {
            var task = (Task) TestCreatorPanel.Tag;

            var textTaskElement = new TextTaskElement
            {
                Height = 50,
                Width = 50
            };

            task.TextTaskElements.Add(textTaskElement);

            TestCreatorPanel.Controls.Add(CreateAnswerRichTextBox(textTaskElement));
        }

        private void InsertImageButton_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new OpenFileDialog
            {
                Filter = @"Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*"
            })
            {
                var dialogResult = dialog.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    return;
                }

                var resultFileName = SaveImage(dialog.FileName);

                var task = (Task) TestCreatorPanel.Tag;

                var imageTaskElement = new ImageTaskElement
                {
                    ImageName = resultFileName,
                    Height = 300,
                    Width = 300
                };

                task.ImageTaskElements.Add(imageTaskElement);

                var pictureBox = CreatePictureBox(imageTaskElement);

                TestCreatorPanel.Controls.Add(pictureBox);
            }
        }

        private string SaveImage(string fromPath)
        {
            var fileName = Path.GetRandomFileName() + ".bin";

            var bitmap = new Bitmap(fromPath);

            new ImageDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder).Update(
                new List<FileUpdateAction<Bitmap>>
                {
                        new FileUpdateAction<Bitmap>
                        {
                            FileName = fileName,
                            SaveInformation = bitmap,
                            Type = FileUpdateActionType.Save
                        }
                });

            return fileName;
        }

        private void InsertAnswerButton_Click(object sender, System.EventArgs e)
        {
        }

        private void HideLabelButton_Click(object sender, System.EventArgs e)
        {
        }

        private void SaveAndCloseButton_Click(object sender, System.EventArgs e)
        {
            var testDevidedFileService =
                new TestDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder);
            testDevidedFileService.Update(new List<FileUpdateAction<Test>>
            {
                new FileUpdateAction<Test>
                {
                    FileName = _test.Name + ".test",
                    SaveInformation = _test,
                    Type = FileUpdateActionType.Save
                }
            });

            Hide();
            var startForm = new StartForm();
            startForm.Closed += (s, args) => Close();
            startForm.Show();
        }

        private void DrawTasksLink()
        {
            var tasks = _test.Tasks;

            TasksFlowLayoutPanel.Controls.Clear();

            foreach (var task in tasks)
            {
                TasksFlowLayoutPanel.Controls.Add(CreatePanelForTask(task));
            }
        }

        private Panel CreatePanelForTask(Task task)
        {
            var linkLabel = new LinkLabel
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F),
                LinkColor = Color.Black,
                Size = new Size(96, 16),
                TabIndex = 0,
                TabStop = true,
                Text = task.Name,
                VisitedLinkColor = Color.Black,
                Tag = task
            };


            var panel = new Panel
            {
                Height = 30,
                Controls = {linkLabel}
            };

            linkLabel.Click += TaskLinkLabel_Click;

            return panel;
        }

        private void TaskLinkLabel_Click(object sender, System.EventArgs e)
        {
            var task = (Task) ((LinkLabel) sender).Tag;

            DrawTestCreatorPanel(task);
        }

        private void DrawTestCreatorPanel(Task task)
        {
            TestCreatorPanel.Controls.Clear();

            TestCreatorPanel.Tag = task;

            foreach (var taskAnswerTaskElement in task.AnswerTaskElements)
            {
            }

            foreach (var taskTextTaskElement in task.TextTaskElements)
            {
                TestCreatorPanel.Controls.Add(CreateAnswerRichTextBox(taskTextTaskElement));
            }

            foreach (var taskImageTaskElement in task.ImageTaskElements)
            {
                TestCreatorPanel.Controls.Add(CreatePictureBox(taskImageTaskElement));
            }
        }

        private RichTextBox CreateAnswerRichTextBox(TextTaskElement element)
        {
            var contextMenu = new ContextMenu();
            var deleteMenuItem = new MenuItem
            {
                Index = 0,
                Text = @"Удалить",
                Shortcut = Shortcut.CtrlDel
            };
            contextMenu.MenuItems.Add(deleteMenuItem);
            deleteMenuItem.Click += RemoveAnswerRichTextBox;

            var richTextBox = new RichTextBox
            {
                Location = element.Point,
                ScrollBars = RichTextBoxScrollBars.None,
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular,
                    GraphicsUnit.Point, 204),
                ContextMenu = contextMenu,
                Tag = element,
                Text = element.Text
            };

            return richTextBox;
        }

        private static PictureBox CreatePictureBox(ImageTaskElement element)
        {
            var bitmap = new ImageDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder).LoadAsBitmap(element.ImageName);
            
            //TODO Сделать адекватное изменение размеров изображения

            var pictureBox = new PictureBox
            {
                Image = bitmap,
                Height = element.Height,
                Width = element.Width,
                Location = element.Point,
                Tag = element
            };

            //TODO Добавить обработку событий драг эн дроп
            //TODO Добавть контекстное меню с удалением. Можно скопировать из CreateAnswerRichTextBox

            return pictureBox;
        }

        private void RemoveAnswerRichTextBox(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem) sender;
            var contextMenu = (ContextMenu) menuItem.Parent;
            var richTextBox = (RichTextBox) contextMenu.SourceControl;

            var element = (TextTaskElement) richTextBox.Tag;

            var currentTask = (Task) TestCreatorPanel.Tag;

            currentTask.TextTaskElements.Remove(element);

            TestCreatorPanel.Controls.Remove(richTextBox);
        }
        
    }
}