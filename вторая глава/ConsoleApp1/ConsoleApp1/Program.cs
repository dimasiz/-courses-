namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Шведко Дмитрий Иванович";
            string emailAdrees = "dmitry.Shvedko.mail.ru";

            byte age = 18;

            float programmingBalls = 87.5f;
            float mathBalls = 67.1f;
            float physicsBalls = 54.9f;

            float summaBalls = mathBalls + programmingBalls + physicsBalls;
            float averages = summaBalls / 3;

            Console.WriteLine($"Ф.И.О:{fullName}\nEmail:{emailAdrees}\nВозраст:{age}\nбалы по програмированию:{programmingBalls}\nбалы по математике: " +
                $"{mathBalls}\nбалы по физике:{physicsBalls}") ;
            Console.ReadKey();

            Console.WriteLine($"Сумма балов{summaBalls}\nсреднее арифметическое{averages}");
            Console.ReadKey();
        }
    }
}