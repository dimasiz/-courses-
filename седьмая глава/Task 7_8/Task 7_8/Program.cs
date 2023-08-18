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
            bool flag = true;

            while (flag)
            {

                Console.WriteLine("1-просмотр списка всех сотрудников\n2-вызов сотрудника по Id\n3-удаление сотрудника по Id\n4-добавление сотрудника\n5-просмотор сотрудниокв по промежутку даты\n6-сортировка\n0-Выход");
                byte chouse = byte.Parse(Console.ReadLine());

                switch (chouse)
                {
                    case 1:
                        repository.PrintAll();
                        repository.GetAllWorkers();
                        break;

                    case 2:
                        Console.WriteLine("Введите ID");
                        int Byid = int.Parse(Console.ReadLine());
                        repository.GetWorkerById(Byid);
                        break;

                    case 3:
                        Console.WriteLine("Введите ID");
                        int DeleteId = int.Parse(Console.ReadLine());
                        repository.DeleteWorker(DeleteId);
                        break;

                    case 4:
                        repository.AddWorker();
                        break;

                    case 5:
                        Console.WriteLine("Введите дату с");
                        DateTime dateto = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите дату после");
                        DateTime dateFor = Convert.ToDateTime(Console.ReadLine());
                        repository.GetWorkersBetweenTwoDates(dateto, dateFor);
                        break;

                    case 6:
                        repository.ComandSort();
                        break;

                    case 0:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверную команду,попробуйте еще раз");
                        break;
                }
            }


        }
    }
}
