using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            bool flag = true;
            int number;
            string enter;

            while (flag)
            {
                Console.WriteLine("Введите число");
                enter = Console.ReadLine();

                if (enter == "")
                {
                    flag = false;
                    break;
                }
                number = int.Parse(enter);

                if (numbers.Contains(number))
                {
                    
                    Console.WriteLine("число уже вводилось ранее");
                }
                else 
                {
                    Console.WriteLine("Ваша число успешно добавлено");
                }

                numbers.Add(number);

            }
        }
    }
}
