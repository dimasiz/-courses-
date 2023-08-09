using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_8
{
    struct Worker
    {
        public Worker(int ID, DateTime time, string FIO, int Age, int Height, string Birthday, string place)
        {
            this.ID = ID;
            this.Time = time;
            this.FIO = FIO;
            this.Age = Age;
            this.Height = Height;
            this.Birthday = Birthday;
            this.Place = place;
        }

        
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public string FIO{ get; set; }
        public int Age { get; set; }
        public int Height { get; set;}
        public string Birthday { get; set;}
        public string Place { get; set; }

        

    }
}
