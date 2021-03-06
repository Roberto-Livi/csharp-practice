﻿using System;
using csharpworld.Math;
using System.Collections.Generic;
using System.Text;

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

            // if statemens
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("Its afternoon");
            }
            else
            {
                System.Console.WriteLine("It's evening");
            }

            // Iteration statements
            var nums = new int[3] {1, 2, 4};
            foreach(var n in nums)
            {
                System.Console.WriteLine("Value: {0}", n);
            }

            // Random Class
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1, 11));
            }

            // Random Password
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            
            var password = new string(buffer);
            System.Console.WriteLine(password);


            // Arrays

            // Rectangular 2D
            var matrix = new int[3, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };
            var element = matrix[1, 1];
            System.Console.WriteLine(element);

            // Jagged Array
            var jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[5];
            jagged[2] = new int[3];

            // Array Methods
            var ns = new[] { 3, 7, 9, 2, 14, 6 };

            // IndexOf()
            var index = Array.IndexOf(ns, 9);
            System.Console.WriteLine("Index of 9: {0}", index);

            // Clear()
            Array.Clear(ns, 0, 2);

            // Copy()
            int[] another = new int[3];
            Array.Copy(ns, another, 3);
            foreach (var n in another)
            {
                System.Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(ns);

            System.Console.WriteLine("Effect of Sort()");
            foreach (var n in ns)
            {
                System.Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(ns);

            System.Console.WriteLine("Effect of Reverse()");
            foreach (var n in ns)
            {
                System.Console.WriteLine(n);
            }

            // Lists
            var list = new List<int>() {1, 2, 3, 4};

            // Add()
            list.Add(1);
            list.AddRange(new int[3] { 5, 6, 7});
            foreach (var n in list)
            {
                System.Console.WriteLine("List Value: {0}", n);
            }

            // IndexOf()
            System.Console.WriteLine("Index of 3: " + list.IndexOf(3));
            System.Console.WriteLine("Index of 1: " + list.LastIndexOf(1));

            // Count()
            System.Console.WriteLine("Count: " + list.Count);

            // Remove
            list.Remove(2);

            // Clear
            list.Clear();

            // Dates
            var now = DateTime.Now;
            var today = DateTime.Today;
            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Minute: " + now.Minute);

            // String Methods
            var fullName = "Roberto Livi";
            System.Console.WriteLine("Trim: '{0}' ", fullName.ToUpper());

            var idx = fullName.IndexOf(' ');
            var fName = fullName.Substring(0, idx);
            var lName = fullName.Substring(idx + 1);
            System.Console.WriteLine("First Name: {0}", fName);
            System.Console.WriteLine("Last Name: {0}", lName);
            System.Console.WriteLine("Index of 1: " + list.IndexOf(3));

            // Replace
            System.Console.WriteLine(fullName.Replace("Roberto", "Marco"));

            // IsNullOrEmpty)()
            if (String.IsNullOrEmpty(fullName))
            {
                System.Console.WriteLine("Invalid");
            }
            else
            {
                System.Console.WriteLine("Valid");
            }

            // Convert String to a Number
            var str = "25";
            var age = Convert.ToInt32(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C"));

            // String Builder (no search methods)
            var builder = new StringBuilder("Hello World");
            System.Console.WriteLine(builder);

            // Append and AppendLine
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            // System.Console.WriteLine(builder);
            
            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            System.Console.WriteLine(builder);

            // Book
            Book book1 = new Book("Bleach", "Tite Kubo", 700);
            

            System.Console.WriteLine(book1.title);

            // Student
            Student s1 = new Student("Jim", "Business", 2.8);
            Student s2 = new Student("Pam", "CS", 3.8);
            System.Console.WriteLine(s1.HasHonors());
            System.Console.WriteLine(s2.HasHonors());

            // Movie
            Movie m1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie m2 = new Movie("Shrek", "Adam Adamson", "P1");

            System.Console.WriteLine(m2.Rating);


            // Song
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            System.Console.WriteLine(Song.songCount);

        }

        public static void Increment(int number){
            number += 10;
        }

        public static void MakeOld(Person person){
            person.Age += 10;
        }
    }
}
