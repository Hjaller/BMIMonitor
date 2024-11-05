// File: Program.cs
using BMIMonitor.ReferenceTypes;
using System;

namespace BMIMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Weight = 70,
                Height = 1.75
            };

            person.CalculateBMI();
            Console.WriteLine($"The BMI for {person.FirstName} {person.LastName} is {person.BMI}");
        }
    }
}
