using System;

namespace Gun5_3_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //  InterfacesIntro();
            // Interfaces2();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
            }
           
            Console.ReadLine();
        }

        private static void Interfaces2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ferdi",
                LastName = "Azboy",
                Department = "Bilgisayar"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }     
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
