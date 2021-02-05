using System;

namespace Gun5_4_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemeğe çık");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaşını al");
        }

        public void Work()
        {
            Console.WriteLine("Çalış");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemeğe çık");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaşını al");
        }

        public void Work()
        {
            Console.WriteLine("Çalış");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalış");
        }
    }
}
