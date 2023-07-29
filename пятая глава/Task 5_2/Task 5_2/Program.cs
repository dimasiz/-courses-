using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    internal class Program
    {
        public static string[] VvodText()
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            return words;
        }

        public static void ReversText(string[] words)
        {
            string newString = null;
            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                newString += words[i] + " ";
            }
            Console.WriteLine(newString);
        }
        static void Main(string[] args)
        {
            
            ReversText(VvodText());
            Console.ReadKey();

        }
    }
}
