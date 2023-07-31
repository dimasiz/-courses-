using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Task_6_1
{
    internal class Program
    {
        public static void ReadInFile()
        {
            using (StreamReader reader = new StreamReader(@"D:\Курс C#\шестая глава\Task 6_1\Task 6_1\staw.txt"))
            {
                string line;
                string[] words = { };

                while ((line = reader.ReadLine()) != null)
                {

                    words = line.Split('#');
                    for(int i = 0; i<words.Length; i++)
                    {
                        Console.Write(words[i] + " ");
                    }
                    Console.WriteLine();
                    
                }
            }
        }

        public static string Info()
        {
            string info;

            Console.WriteLine("Запишите Id работника");
            info = Console.ReadLine();

            Console.WriteLine("Введите Ф.И.О");
            info += "#" + DateTime.Now;
            info += "#" + Console.ReadLine();

            Console.WriteLine("Введите возраст");
            info += "#" + Console.ReadLine();

            Console.WriteLine("Введите Рост");
            info += "#" + Console.ReadLine();


            Console.WriteLine("Введите Дату рождения");
            info += "#" + Console.ReadLine();

            Console.WriteLine("Введите место рождения");
            info += "#" + Console.ReadLine();

            return info;
        }

        public static void WriteInFile()
        {
            FileInfo staw = new FileInfo(@"D:\Курс C#\шестая глава\Task 6_1\Task 6_1\staw.txt");
           
            if (staw.Exists)
            {
                using (StreamWriter writer = new StreamWriter(@"D:\Курс C#\шестая глава\Task 6_1\Task 6_1\staw.txt", true))
                {
                    writer.WriteLine(Info());
                }
                
            }
            else if(staw.Exists == false)
            {
                staw.Create();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для того чтобы считать файл нажмите - 1\nДля того чтобы записать в файл нажмите - 2\nДля того чтобы выйти с програмы нажмите - 3");
            byte action = byte.Parse(Console.ReadLine());
            bool work = true;
            while (work)
            {
                if (action == 1)
                {
                    ReadInFile();
                    Console.WriteLine("\nДля того чтобы считать файл нажмите - 1\nДля того чтобы записать в файл нажмите - 2\nДля того чтобы выйти с програмы нажмите - 3");
                    action = byte.Parse(Console.ReadLine());
                }
                else if (action == 2)
                {
                    WriteInFile();
                    Console.WriteLine("\nДля того чтобы считать файл нажмите - 1\nДля того чтобы записать в файл нажмите - 2\nДля того чтобы выйти с програмы нажмите - 3");
                    action = byte.Parse(Console.ReadLine());
                }
                else if(action == 3)
                {
                    work = false;
                }
               
            }
        }
    }
}
