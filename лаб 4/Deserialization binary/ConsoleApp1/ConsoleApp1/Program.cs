using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fs1 = new FileStream(@"C:\Users\Asus\Desktop\Serialization binary\data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = bf.Deserialize(fs1) as Student;
            Console.WriteLine(b.name + " " + b.surname);
            Console.ReadKey();
        }
    }
}
