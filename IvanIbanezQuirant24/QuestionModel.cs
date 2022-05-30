using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanIbanezQuirant24
{
    internal class QuestionModel
    {
        private string question;
        private string [] answer;
        private int value;

        public QuestionModel(string question, string[] answer, int value)
        {
            this.Question = question;
            this.Answer = answer;
            this.Value = value;
        }

        public string Question { get => question; set => question = value; }
        public string[] Answer { get => answer; set => answer = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
