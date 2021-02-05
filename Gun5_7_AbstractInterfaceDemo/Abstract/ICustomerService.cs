using Gun5_7_AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_7_AbstractInterfaceDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
