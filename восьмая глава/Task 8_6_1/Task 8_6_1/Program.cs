using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_6_1
{
    internal class Program
    {
        public static List<int> RandomList()
        {
            int count = 100;
            Random random = new Random();
            List<int> numbers = new List<int>();

            for(int i = 0;i < count; i++)
            {
                numbers.Add(random.Next(101));
                
            }
            return numbers;
        }

        public static List<int> ListSort() 
        {
            List<int> numbers = RandomList();

            for(int i = 0; i < numbers.Count; i++)
            {
                if((numbers[i]>25) && (numbers[i] < 50))
                {
                    numbers.RemoveAt(i);
                }
            }
            return numbers;
        }

        public static void PrintList(List<int> printNumbers)
        {
            for(int i = 0; i < printNumbers.Count; i++)
            {
                Console.Write(printNumbers[i] + " ");
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("100 рандомных чисел:");
            RandomList();
            PrintList(RandomList());

            Console.WriteLine();

            Console.WriteLine("отсортированый список:");
            ListSort();
            PrintList(ListSort());

            Console.ReadLine();
        }
    }
}
