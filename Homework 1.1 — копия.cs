using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "qwerty12345";
            // Проверка на лишние символы
            byte[] bytes = new byte[192];
            int symb = 0;
            for (int i = 0; i < 47; i++)
            {
                bytes[symb] = (byte)i;
                symb++;
            }
            for (int i = 58; i < 64; i++)
            {
                bytes[symb] = (byte)i;
                symb++;
            }
            for (int i = 91; i < 96; i++)
            {
                bytes[symb] = (byte)i;
                symb++;
            }
            for (int i = 123; i < 255; i++)
            {
                bytes[symb] = (byte)i;
                symb++;
            }

            char[] chars = System.Text.Encoding.ASCII.GetChars(bytes);

            bool flag = false;

            foreach (var item in chars)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] == item)
                    {
                        flag = true;
                    }
                }
            }

            //
            if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)
                Console.WriteLine("Логин - {0}, корректен", login);
            else
                Console.WriteLine("Логин не корректен");
        }
    }
}
