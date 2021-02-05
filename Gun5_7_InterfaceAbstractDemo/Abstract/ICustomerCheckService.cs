using Gun5_7_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_7_InterfaceAbstractDemo.Abstract
{
   public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
