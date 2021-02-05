using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Delete(Order order)
        {
            Console.WriteLine("Order deleted" + " " + order.Id);
        }

        public void Save(Order order)
        {
            Console.WriteLine("Order saved" + " " + order.Id);
        }

        public void Update(Order order)
        {
            Console.WriteLine("Order updated" + " " + order.Id);
        }
    }
}
