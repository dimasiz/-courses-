namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Введите число:");

            number =  Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число:{number} четное");
            }
            else
            {
                Console.WriteLine($"Число:{number} не четное");
            }
            Console.ReadKey(); 

        }
    }
}