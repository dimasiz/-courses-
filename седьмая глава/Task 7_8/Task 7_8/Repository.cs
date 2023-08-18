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
                   workers.Clear();
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

            for (int i = 0; i < IdWorkers.Count; i++)
            {
                IdWorkers[i].Print();
            }
        }
        public void SortWorkerAge()
        {

            List<Worker> SortWorkers = GetAllWorkers();
            Worker MinWorker = new Worker();
            MinWorker = SortWorkers[0];
            int len = SortWorkers.Count;
            for (int i = 0; i < SortWorkers.Count; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (SortWorkers[i].Age > SortWorkers[j].Age)
                    {
                        MinWorker = SortWorkers[i];
                        SortWorkers[i] = SortWorkers[j];
                        SortWorkers[j] = MinWorker;
                    }
                }
            }

            for (int i = 0; i < SortWorkers.Count; i++)
            {
                SortWorkers[i].Print();
            }
            
        }
        public void SortWorkerHeight()
        {

            List<Worker> SortWorkers = GetAllWorkers();
            Worker MinWorker = new Worker();
            MinWorker = SortWorkers[0];
            int len = SortWorkers.Count;
            for (int i = 0; i < SortWorkers.Count; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (SortWorkers[i].Height > SortWorkers[j].Height)
                    {
                        MinWorker = SortWorkers[i];
                        SortWorkers[i] = SortWorkers[j];
                        SortWorkers[j] = MinWorker;
                    }
                }
            }

            for (int i = 0; i < SortWorkers.Count; i++)
            {
                SortWorkers[i].Print();
            }

        }
        public void SortWorkerDate()
        {

            List<Worker> SortWorkers = GetAllWorkers();
            Worker MinWorker = new Worker();
            MinWorker = SortWorkers[0];
            int len = SortWorkers.Count;
            for (int i = 0; i < SortWorkers.Count; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (SortWorkers[i].Time > SortWorkers[j].Time)
                    {
                        MinWorker = SortWorkers[i];
                        SortWorkers[i] = SortWorkers[j];
                        SortWorkers[j] = MinWorker;
                    }
                }
            }

            for (int i = 0; i < SortWorkers.Count; i++)
            {
                SortWorkers[i].Print();
            }

        }
    }
}