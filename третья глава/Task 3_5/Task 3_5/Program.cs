namespace Task_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int up;
            int hiddenNumber;
            string number;
            int count = 0;
            bool play = true;
            
            
            Console.WriteLine("Введите верхнию границу");
            up = int.Parse(Console.ReadLine());

            Random random = new Random();
            hiddenNumber = random.Next(0, up + 1);
            Console.WriteLine("Введите число:");

            while (play)
            {
                

                count += 1;
                number = Console.ReadLine();

                if (number == "")
                {
                    play = false;
                    Console.WriteLine($"было загадно число:{hiddenNumber}");
                }

                else if (int.Parse(number) > hiddenNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else if (int.Parse(number) < hiddenNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (int.Parse(number) == hiddenNumber)
                {
                    Console.WriteLine($"Поздравляю вы победили за {count} ходов");
                    play = false;
                }
               
                
            }
            Console.ReadKey();
        }
    }
}