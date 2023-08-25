using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace Task_8_6_4
{
    internal class Program
    {
       public static void XmlFile(string name,string street, string numberHome, string numberFlat, string mobilePhone, string flatPhone)
        {
            XmlTextWriter writer = new System.Xml.XmlTextWriter("Person.xml", System.Text.Encoding.UTF8);

            writer.WriteStartDocument();
            writer.WriteStartElement("Person");
            writer.WriteAttributeString("name", name);

            writer.WriteStartElement("Address");

            writer.WriteStartElement("Street");
            writer.WriteString(street);
            writer.WriteEndElement();

            writer.WriteStartElement("HouseNumber");
            writer.WriteString(numberHome);
            writer.WriteEndElement();

            writer.WriteStartElement("FlatNumber");
            writer.WriteString(numberFlat);
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteStartElement("Phones");
            writer.WriteStartElement("MobilePhone");
            writer.WriteString(mobilePhone);
            writer.WriteEndElement();

            writer.WriteStartElement("FlatPhone");
            writer.WriteString(flatPhone);
            writer.WriteEndElement();

            writer.WriteEndElement();




            
            writer.WriteEndDocument();



            writer.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите название улицы");
            string street = Console.ReadLine();

            Console.WriteLine("Введите номер дома");
            string numberHome = Console.ReadLine();

            Console.WriteLine("Введите номер квартиры");
            string numberFlat = Console.ReadLine();

            Console.WriteLine("Введите мобильный телефон");
            string mobilePhone  = Console.ReadLine();

            Console.WriteLine("Введите домашний телефон");
            string flatPhone = Console.ReadLine();
            

            XmlFile(name,street,numberHome,numberFlat, mobilePhone, flatPhone);
        }
    }
}
