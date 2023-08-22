using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> guide = new Dictionary<string, string>();
            bool flag = true;
            string number;
            string name;

            while (flag)
            {
                Console.WriteLine("Впишите номер телефона");
                number = Console.ReadLine();

                if (number == "")
                {
                    flag = false;
                    break;
                }

                Console.WriteLine("Впишите имя");
                name = Console.ReadLine();

                guide.Add(number, name);

            }

            Console.WriteLine("Введите номер телефона человека которого хотите найти");
            number = Console.ReadLine();

            if (guide.TryGetValue(number, out name))
            {
                Console.WriteLine(name);
            }

            else if (guide.TryGetValue(number, out name) == false)
            {
                Console.WriteLine("Такого номера нету");
            }

            Console.ReadKey();
        }
    }
}
