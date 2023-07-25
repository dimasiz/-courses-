namespace Task_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            int count;
            int firstNumber = 0;

            Console.WriteLine("Введите колличевство чисел");
            count = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа через Enter");
            for (int i = 0; i < count; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (firstNumber > numbers)
                {
                    firstNumber = numbers;
                }
            }
            Console.WriteLine($"Минимальное число:{firstNumber}");
            Console.ReadKey();



        }
    }
}