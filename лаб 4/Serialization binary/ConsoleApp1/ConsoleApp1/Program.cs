using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Madiyar", "Turmukhanbet");


            FileStream fs = new FileStream(@"C:\Users\Asus\Desktop\Serialization binary\data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, a);
            fs.Close();
        }
    }
}
