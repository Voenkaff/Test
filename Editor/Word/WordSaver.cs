using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Models.Test;
using Services.Configuration;
using Services.Services.Implementations.FileServices;

namespace Editor.Word
{
    public class WordSaver
    {
        public static void CreateDocument(Test test)
        {
            //var saveFileDialog = new SaveFileDialog
            //{
            //    Filter = @"Word Documents (*.docx)|*.docx",
            //    FileName = $"Тест {test.Name}.docx"
            //};

            //if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            //try
            //{
            //    // Путь до шаблона документа
            //    File.Delete(Environment.CurrentDirectory + @"\Word\" + test.Name + ".docx");
            //    File.Copy(Environment.CurrentDirectory + @"\Word\WordTest.docx",
            //        Environment.CurrentDirectory + @"\Word\" + test.Name + ".docx");
            //    var source = Environment.CurrentDirectory + @"\Word\" + test.Name + ".docx";
            //    // Открываем
            //    var doc = Documents.Open(source);
            //    doc.Activate();

            //    // Добавляем информацию
            //    // wBookmarks содержит все закладки
            //    var wBookmarks = doc.Bookmarks;

            //    //string[] data = new string[3] { "27", "Alex", "Gulynin" };


            //    foreach (Bookmark mark in wBookmarks)
            //    {
            //        switch (mark.Name)
            //        {
            //            case "testName":
            //                mark.Range.Text = test.Name;
            //                break;
            //            case "markExcellent":
            //                mark.Range.Text = test.Marks.Excellent.ToString();
            //                break;
            //            case "markGood":
            //                mark.Range.Text = test.Marks.Good.ToString();
            //                break;
            //            case "markSatisfactory":
            //                mark.Range.Text = test.Marks.Satisfaction.ToString();
            //                break;
            //        }

            //        if (mark.Name != "tasksStartHere") continue;

            //        var textForInsert = "";
            //        var count = 0;

            //        //KeyValuePair<LinkLabel, PanelWrapper> keyValue

            //        foreach (var task in test.Tasks)
            //        {
            //            var textBoxs = new List<TextBox>();

            //            textForInsert += $"\n\n\n\nЗадание №{count + 1}\n";
                        
            //            textForInsert += "Условие: ";

            //            foreach (var taskTextTaskElement in task.TextTaskElements)
            //            {
            //                textForInsert += taskTextTaskElement.Text + "\n";
            //            }

            //            foreach (var taskImageTaskElement in task.ImageTaskElements)
            //            {
            //                var image = new ImageDevidedFileService(ConfigContainer.GetConfig<EditorConfig>().SaveFolder)
            //                    .LoadAsBitmap(taskImageTaskElement.ImageName);

            //                Clipboard.SetImage(image);

            //                mark.Range.Paste();
            //            }


            //            foreach (var taskAnswerTaskElement in task.AnswerTaskElements)
            //            {
            //                textForInsert += taskAnswerTaskElement.LabelText + "\n";
            //                textForInsert += taskAnswerTaskElement.Answer + "\n";
            //            } 

            //            count++;
            //        }

            //        mark.Range.Text = textForInsert;
            //    }

            //    doc.SaveAs2000(saveFileDialog.FileName);
            //    File.Delete(source);
            //    doc.Close( /*ref missing, ref missing, ref missing*/);
            //}

            //catch (IOException e)
            //{
            //    MessageBox.Show(@"Не удалось сохранить файл, возможно он уже существует " + e.Message,
            //        @"Есть несохраненные результаты!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}