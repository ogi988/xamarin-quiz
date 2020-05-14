using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Models
{
    class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public int Difficulty { get; set; }
    }
}
