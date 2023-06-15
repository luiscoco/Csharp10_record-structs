using System;

//You can declare value type records using the "record struct" or "readonly record struct" declarations.
//You can now clarify that a "record" is a "reference type" with the record class declaration.
record struct Person(string FirstName, string LastName, int Age);

class Program
{
    static void Main()
    {
        // Create a new Person record
        Person person = new Person("John", "Doe", 30);

        Console.WriteLine(person);

        // Update the record with a new value for the Age field
        Person updatedPerson = person with { Age = 35 };

        Console.WriteLine(updatedPerson);

        // Compare two records for equality
        bool areEqual = person.Equals(updatedPerson);
        Console.WriteLine($"Are the records equal? {areEqual}");

        // Deconstruct the record into individual variables
        var (firstName, lastName, age) = person;
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"Age: {age}");
    }
}
