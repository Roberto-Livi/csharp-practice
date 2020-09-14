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

            // Arrays
            var numbers = new int[3] {1, 2, 3};
            System.Console.WriteLine(numbers[2]);

            var names = new string[2] {"Jack", "Jill"};
            System.Console.WriteLine(names[0]);

            // Strings
            var firstName = "Rob";
            string lastName = "Livi";
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var nms = new string[3] {"Jack", "John", "Mary"};
            var formattedNames = string.Join(", ", nms);
            System.Console.WriteLine(formattedNames);
            
        }
    }
}
