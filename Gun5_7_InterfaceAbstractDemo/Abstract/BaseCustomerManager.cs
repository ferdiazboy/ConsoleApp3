using Gun5_7_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_7_InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerSeervice
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db"+customer.FirstName);
        }
    }
}
