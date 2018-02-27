using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream(@"C:\Users\Asus\Desktop\Serialization Xml\data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = xs.Deserialize(fs) as Student;
            Console.WriteLine(b.name + " " + b.surname);
            Console.ReadKey();
        }
    }
}
