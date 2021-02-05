using System;

namespace Gun5_5_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{FirstName="Ferdi" }, new Customer{FirstName="Mercan"}, new Student{FirstName="Serhat"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2
    {

    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
