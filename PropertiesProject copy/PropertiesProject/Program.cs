using System;

namespace PropertiesProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("Peter Griffin", true, 20);
            s.Age = 15;
            Console.WriteLine(s);
        }
    }
}
