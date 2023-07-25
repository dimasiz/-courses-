namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool check = true;
            int divider = 1;

            Console.WriteLine("Введите чило:");
            number = int.Parse(Console.ReadLine());

            while (check)
            {
                if(divider < number - 1)
                {
                    divider += 1;
                }

                if(number % divider == 0)
                {
                    Console.WriteLine($"Число {number}:не простое");
                    check = false;
                }
                else
                {
                    Console.WriteLine($"Число {number}:простое");
                    check = false;
                }
            }
            Console.ReadKey();
        }
    }
}