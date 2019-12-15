using System;

namespace PersonExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("First Name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Gender: ");
            var gender = Console.ReadLine();

            var person = new Person(firstName, lastName, gender);
            Console.WriteLine($"You entered: {person.FullName} ({person.GenderName})");
        }
    }
}
