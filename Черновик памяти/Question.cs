using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик_памяти
{
    class Question
    {

        public string Text { get; set; }        // Текст вопроса
        public string Answer { get; set; }   // 4 варианта ответа


        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;

        }
    }
}
