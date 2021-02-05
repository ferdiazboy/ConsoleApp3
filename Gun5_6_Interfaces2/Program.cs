using System;

namespace Gun5_6_Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // interfac new'lenemez
            IPersonManager[] personManagers = new IPersonManager[3]
            {
                new CustomerManager(),
                new EmployeeManager(),
                new InternManager()
            };
            foreach (var personManager in personManagers)
            {
                personManager.Add();
            }
            Console.WriteLine();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

            
        }
    }
    //implements - interface --------- inherits - class
    interface IPersonManager
    {
        //unimplemented operations
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Customer Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Employee Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Intern güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
