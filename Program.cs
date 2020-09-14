using System;
using csharpworld.Math;

namespace csharpworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(3, 4));

        }
    }
}
