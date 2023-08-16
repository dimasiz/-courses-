using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_8
{
    class Repository
    {
        private string path = "staw.txt";
        private List<Worker> workers = new List<Worker>();
        public List<Worker> GetAllWorkers()
        {
            FileInfo staw = new FileInfo(path);
            int count = File.ReadAllLines(path).Length;

            if (staw.Exists)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                   
                    string[] words = { };
                   for (int i = 0; i < count ; i++)
                    {

                        words = reader.ReadLine().Split('#');
                        int id = int.Parse(words[0]);
                        DateTime time = Convert.ToDateTime(words[1]);
                        string fio = words[2];
                        int age = int.Parse(words[3]);
                        int height = int.Parse(words[4]);
                        string birthday = words[5];
                        string place = words[6];
                        Worker worker = new Worker(id, time, fio, age, height, birthday, place);
                        workers.Add(worker);
                    }
                    reader.Close();
                    return workers;
                }

            }
            else
            {
                staw.Create();
                Console.WriteLine("Файл был создан");
                return null;

            }
        }


            public Worker GetWorkerById(int Id)
            {
            int count = File.ReadAllLines(path).Length;
            List <Worker> IdWorkers = GetAllWorkers();
            Worker worker = new Worker();

            for (int i = 0; i < IdWorkers.Count; i++)
            {

                if(IdWorkers[i].ID == Id)
                {
                    worker = IdWorkers[i];
                    worker.Print();
                   
                }
                
            }
            return worker;

            }

        public void DeleteWorker(int Id)
        {
            
            List<Worker> IdWorkers = GetAllWorkers();
     
            for (int i = 0; i < IdWorkers.Count; i++)
            {

                if (IdWorkers[i].ID == Id)
                {
                    IdWorkers.RemoveAt(i);
                    break;

                }

            }
            //1#31.07.2023 21:39:13#Иванов Иван Иванович#25#176#05.05.1992#город Москва
            //2#31.07.2023 21:47:33#Шведко Дмитрий Иванович#18#190#21.12.2004#Город Гродно
            //3#31.07.2023 22:26:00#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск
            //4#31.07.2023 22:27:22#Колесник Андрей Николаевич#21#156#05.02.2002#Город Минск
            //5#31.07.2023 22:30:43#Добровольская Ксения Андреевна#17#167#25.06.2005#Город Брест
            File.WriteAllText(path, string.Empty);
            using (StreamWriter writer = new StreamWriter(path))
            {
                
                for (int i = 0; i < IdWorkers.Count ; i++)
                {
                    int id = IdWorkers[i].ID;
                    DateTime time = IdWorkers[i].Time;
                    string fio = IdWorkers[i].FIO;
                    int age = IdWorkers[i].Age;
                    int height = IdWorkers[i].Height;
                    string birthday = IdWorkers[i].Birthday;
                    string place = IdWorkers[i].Place;
                    writer.WriteLine($"{id}#{time}#{fio}#{age}#{height}#{birthday}#{place}");
                }
                writer.Close();
            }
        }
        public void AddWorker()
        {
            Console.WriteLine("Запишите Id работника");
            int id = int.Parse(Console.ReadLine());

            DateTime time = DateTime.Now;

            Console.WriteLine("Введите Ф.И.О");
            string fio = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Рост");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Дату рождения");
            string birthday = Console.ReadLine();

            Console.WriteLine("Введите место рождения");
            string place = Console.ReadLine();

            Worker  worker = new Worker (id, time, fio, age, height, birthday, place);

            using (StreamWriter writer = new StreamWriter(path,true))
            { 
                writer.WriteLine($"{id}#{time}#{fio}#{age}#{height}#{birthday}#{place}");
                writer.Close();
            }
        }
        public List<Worker> GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            int count = File.ReadAllLines(path).Length;
            List<Worker> IdWorkers = GetAllWorkers();
            List<Worker> SortedWorker = new List<Worker>();

            for (int i = 0; i < IdWorkers.Count; i++)
            {

                if ((dateFrom < IdWorkers[i].Time) && (IdWorkers[i].Time < dateTo))
                {
                    SortedWorker.Add(IdWorkers[i]);
                    IdWorkers[i].Print();
                }

            }

            
            return SortedWorker;
        }
        public void PrintAll()
        {
            List<Worker> IdWorkers = GetAllWorkers();
            Worker worker = new Worker();

            for (int i = 0; i < IdWorkers.Count; i++)
            {
                IdWorkers[i].Print();
            }
        }
    }
}