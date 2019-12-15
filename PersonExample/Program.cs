using System;
using System.Collections.Generic;

namespace PersonExample
{
    internal class Program
    {
        private static readonly List<Person> People = new List<Person>();

        private static void Main()
        {
            while (true)
            {
                Console.Write("First Name: ");
                var firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                var lastName = Console.ReadLine();
                Console.Write("Gender: ");
                var gender = Console.ReadLine();

                var person = new Person(firstName, lastName, gender);
                People.Add(person);

                Console.Write("Add another person? ");
                var answer = Console.ReadLine();
                if (answer != null && answer.ToLower() != "y" && answer.ToLower() != "yes")
                    break;
            }

            foreach (var person in People)
            {
                Console.WriteLine($"You entered: {person.FullName} ({person.GenderName})");
            }
            
        }
    }
}
