using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        public double gpa;
        public Student() { }
        public Student(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            gpa = 2.3;
        }
    }
}
