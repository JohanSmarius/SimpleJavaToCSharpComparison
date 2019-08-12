using System;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher("Johan", "Smarius", "jawsmari");

            var dotNetClass = new Class("Dotnet rocks!", teacher);

            var student1 = new Student("Paul", "Allen", 1001);
            var student2 = new Student("Bill", "Gates", 1002);

            dotNetClass.AddStudent(student1);
            dotNetClass.AddStudent(student2);

            Console.WriteLine($"The persons in this class {dotNetClass.Title} are:");
            foreach (var person in dotNetClass.GetAllPersons())
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}
