using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Веведите колличевство строк:");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите колличевство столбцев");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrixFirst = new int[lines, columns];
            int[,] matrixSecond = new int[lines, columns];
            int[,] matrixThird = new int[lines, columns];

            Random random = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixFirst[i, j] = random.Next(0, 101);
                    matrixSecond[i, j] = random.Next(0, 101);
                    matrixThird[i, j] = matrixFirst[i, j] + matrixSecond[i, j];
                }
            }

            Console.WriteLine("Первая матрица");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    Console.Write($"{matrixFirst[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write($"{matrixSecond[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Третья матрица");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write($"{matrixThird[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
