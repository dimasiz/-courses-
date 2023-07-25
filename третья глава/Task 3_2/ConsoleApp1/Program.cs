using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            int numberDiller;
           
            byte nextGame;
            bool play = true;
            string naminal;

            Console.WriteLine("Добро пожаловать в казион SkillBox\nВы находитесть за столом для игры в 21\nМеня зовут Дмитрий, я ваш дилер\nВ нашем казино действуют такие правила: карты с цифрами соответсвуют наминалу, картинки же стоят 10 очков\nтабличка записи картинок\nВалет = J\nДама = Q\nКороль = K\nТуз = T");
            

            while (play)
            {
                int summa = 0;

                Console.WriteLine("Скажиье сколько у вас карт");
                count = int.Parse(Console.ReadLine());

                Random random = new Random();
                numberDiller = random.Next(15, 22);

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Введите наминал вашей карты:");
                    naminal = Console.ReadLine();

                    switch (naminal)
                    {
                        case "J" or "K" or "Q" or "T":
                            summa += 10;
                            break;

                        case "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9":
                            summa += int.Parse(naminal);
                            break;
                    }
                }
                Console.WriteLine($"сумма ваших карт равна:{summa}");
                Console.WriteLine($"Сумма карт диллера равна:{numberDiller}");

                if (summa > 21)
                {
                    Console.WriteLine("У вас перебор");
                }
                else if (summa > numberDiller)
                {
                    Console.WriteLine("Вы победили поздравлю");
                }
                else if (summa < numberDiller)
                {
                    Console.WriteLine("Вы проиграли ваши ставки сгорели");
                }
                else
                {
                    Console.WriteLine("Одинаковое колличевство,никто не выйграл ");
                }

                Console.WriteLine("Продолжите игру \nДа = 1\nнет = 0");
                nextGame = byte.Parse(Console.ReadLine());
                if (nextGame == 0)
                {
                    play = false;
                }
            }

            
        }
    }
}