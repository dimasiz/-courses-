using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Repository repository = new Repository();
            DateTime date1 = new DateTime(2023,07,31);
            DateTime date2 = new DateTime(2023,08,01);
            
            repository.PrintAll();
            Console.ReadLine();
            
        }
    }
}
