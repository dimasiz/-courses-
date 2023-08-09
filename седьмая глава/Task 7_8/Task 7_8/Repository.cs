using System;
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

       
        public Worker AddWorker()
        {
            Console.WriteLine("Запишите Id работника");
           int  ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ф.И.О");
           DateTime Time = DateTime.Now;
           string FIO = Console.ReadLine();

            Console.WriteLine("Введите возраст");
           int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Рост");
            int Height = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите Дату рождения");
            string Birthday = Console.ReadLine();

            Console.WriteLine("Введите место рождения");
            string Place = Console.ReadLine();
            Worker worker = new Worker(ID,Time,FIO,Age,Height,Birthday,Place);

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLineAsync($"{worker.ID}#{worker.Time}#{worker.FIO}#{worker.Age}#{worker.Height}#{worker.Birthday}#{worker.Place}");
                writer.Close();
            }

                return worker;
        }
        public Worker[] GetAllWorkers()
        {
            FileInfo staw = new FileInfo(path);
            if (staw.Exists)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    string[] words = { };
                    string[] workers = { };
                    Worker[] worker = { };


                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        words = line.Split('#');
                        
                        for (int i = 0; i < line.Length; i++)
                        {
                            Console.Write(words[i] + " ");
                            
                            Worker info = new Worker(int.Parse(words[0]), DateTime.Parse(words[1]),words[2].ToString(), int.Parse(words[3]), int.Parse(words[4]), words[5].ToString(), words[6].ToString());
                            worker[i] = info; 
                        }
                        Console.WriteLine();

                    }
                    reader.Close();
                    return worker;
                }
                
            }
            else
            {
                staw.Create();
                Console.WriteLine("Файл был создан");
                return null;


            }
        }

        public void GetWorkerById(int Id)
        {
            Console.WriteLine("Ведите ID");
            int id = int.Parse(Console.ReadLine());
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                line = reader.ReadLine();
                while (line != null)
                {
                    if (line[0] == id)
                    {
                        Console.WriteLine(line);
                        break;
                    }
                }
                line.Split('#');
               
                reader.Close();
              

            }
        }

        public void DeleteWorker(int Id)
        {
            Console.WriteLine("Ведите ID");
            int id = int.Parse(Console.ReadLine());
            FileInfo staw = new FileInfo(path);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                line = reader.ReadLine();
                while (line != null)
                {
                    if (line[0] == id)
                    {
                        line = null;
                        break;
                    }
                }
                reader.Close();
                File.WriteAllText(path, reader.ToString());
            }


        }
        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                line = reader.ReadLine();
                line.Split('#');
                
                while (line != null)
                {
                    if (dateFrom <= Convert.ToDateTime(line[1])&&(Convert.ToDateTime(line[1])>= dateTo))
                    {
                        Console.WriteLine(line);
                         }
                }

                return null;
            }
            
        }
    }
}
