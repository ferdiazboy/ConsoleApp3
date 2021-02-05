using Gun5_7_InterfaceAbstractDemo.Abstract;
using Gun5_7_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_7_InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
