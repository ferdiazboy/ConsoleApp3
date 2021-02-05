using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1989, 12, 12), FirstName = "Ferdi", LastName = "Azboy", NationalityId = "16591926032" });
            Console.ReadLine();
        }
    }
}
