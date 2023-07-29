using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    internal class Program
    {
        public static string[] VvodText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        public static void SplitText(string[] words)
        {
            for(int i = 0;i < words.Length; i++)
            {
                Console.WriteLine(words[i]);    
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            SplitText(VvodText(text));
            Console.ReadKey();  

        }
    }
}
