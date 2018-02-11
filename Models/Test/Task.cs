using System.Collections.Generic;

namespace Models.Test
{
    public class Task
    {
        public string Name { get; set; }
        public List<TextTaskElement> TextTaskElements { get; set; } = new List<TextTaskElement>();
        public List<ImageTaskElement> ImageTaskElements { get; set; } = new List<ImageTaskElement>();
        public List<AnswerTaskElement> AnswerTaskElements { get; set; } = new List<AnswerTaskElement>();
    }
}