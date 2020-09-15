using System;
using csharpworld.Math;

namespace csharpworld
{

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


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
            

            // Enums
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);
            System.Console.WriteLine(method.ToString());

            // Reference Types
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            System.Console.WriteLine(array1[0]);
            System.Console.WriteLine(array2[0]);

            var number = 1;
            Increment(number);
            System.Console.WriteLine(number);

            var person = new Person() {Age = 20};
            MakeOld(person);
            System.Console.WriteLine(person.Age);

        }

        public static void Increment(int number){
            number += 10;
        }

        public static void MakeOld(Person person){
            person.Age += 10;
        }
    }
}
