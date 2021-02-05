using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
