using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T2
{
    class Program
    {
        public class Student
        {
            public string name;
            public string id;
            public int year;

            public void GetName() // метод для вывода имени студента
            {
                Console.WriteLine(name);
            }

            public void GetId() // метод для вывода айди студента
            {
                Console.WriteLine(id);
            }

            public void GetYear() // метод для вывода года обучения
            {
                Console.WriteLine(year);
            }

            public Student(string s, string i, int t) { name = s; id = i; year = t; } //конструктор

        }
        static void Main(string[] args)
        {
            Student bob = new Student("bob", "kjdfjf", 2018); // вызов конструктора
        }
    }
}
