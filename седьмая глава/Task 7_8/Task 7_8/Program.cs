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
            Worker [] w = repository.GetAllWorkers();
            for (int i = 0;w.Length > i;i++) 
            {
                Console.WriteLine(w[i]);
            }
            
            Console.ReadLine();
            
        }
    }
}
