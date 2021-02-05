using Gun5_7_AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_7_AbstractInterfaceDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to db:" + customer.FirstName);
        }
    }
}
