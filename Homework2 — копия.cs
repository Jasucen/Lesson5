using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаю предложение, с которым в дальнейшем буду работать.
            String text = "Когда нибудь, я уйду из своей шизанутой специальности и стану тру-прогером. А пока что, я буду стараться нагнать свой курс по первому интенсиву.";
            //пишу первое, что пришло в голову и вывожу только те слова, которые содержат от пяти и менее букв.
            Console.WriteLine(String.Join(" ", text.Split().Where(y => y.Length <= 5)));
            //задаю символ "ь", слова с которым не будут выводиться на консоль
            Console.WriteLine(String.Join(" ", text.Split().Where(x => x[x.Length - 1] != 'т' && !(x[x.Length - 1] == '.' && x[x.Length - 2] == 'ь'))));
            //нахожу по условиям самое длинное слово из своего сообщения
            Console.WriteLine(text.Split(' ').OrderBy(m => m.Length).Last());
            //формирую сообщение из самых длинных слов переменной text
            Console.WriteLine(String.Join(" ", text.Split(' ').Where(n => n.Length == text.Split(' ').Max(l => l.Length))));

        }
    }

}
   
