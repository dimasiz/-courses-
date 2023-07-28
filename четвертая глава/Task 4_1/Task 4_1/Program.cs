namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Веведите колличевство строк:");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите колличевство столбцев");
            int columns = int.Parse(Console.ReadLine());

            int [,] matrix = new int[lines, columns];

            Random random = new Random();   

            for (int i = 0; i < lines; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 101);
                    Console.Write($"{matrix[i, j],5}") ; 
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}