using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Student
    {
        public string name;
        public int age;
        public float gpa;

        public Student() //Создаем конструктор без аргументов, но с начальными значениями
        {
            name = "Madiyar";
            age = 18;
            gpa = 4;
        }

        public Student(string n, int a, float g) //Создаем конструктор с аргументами
        {
            name = n;
            age = a;
            gpa = g;
        }

        public override string ToString() //Выводим все данные в строку, при вызове Console.WriteLine(название класса); 
        {
            return name + " " + age + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); //Создаем класс без значений
            s.name = "Dias"; //Даем значение 
            Console.WriteLine(s); 


            Student s2 = new Student("Mamut", 18, 3); //Создаем класс со значениями
            Console.WriteLine(s2); 
            Console.ReadKey();
        }
    }
}