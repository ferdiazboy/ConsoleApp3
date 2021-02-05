using Gun5_7_InterfaceAbstractDemo.Abstract;
using Gun5_7_InterfaceAbstractDemo.Concrete;
using System;

namespace Gun5_7_InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(1989, 10, 11),
                FirstName = "Ferdi",
                LastName = "Azboy",
                NationalityId = "11111111111"
            });

        }
    }
}
