using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Robot robot = new Robot();
            robot.Work();
            Console.WriteLine("*************************");

            Worker worker = new Worker();
            worker.Work();
            worker.Eat();
            worker.GetSalary();

            Console.ReadLine();







        }

        interface IEat
        {
            void Eat();

        }

        interface IWork
        {
            void Work(); // public yazmayız çünkü defaultu publictir. 

        }

        interface ISalary
        {
            void GetSalary();

        }

        class Robot : IWork
        {
            public void Work()
            {
                Console.WriteLine("Robot sadece çalışır");

            }
        }
        class Worker : IWork, ISalary, IEat
        {
            public void Eat()
            {
                Console.WriteLine("Worker yemek yer");


            }

            public void GetSalary()
            {
                Console.WriteLine("Worker maaş alır");

            }

            public void Work()
            {
                Console.WriteLine("Worker çalışır");

            }
        }

        class Manager : IWork, ISalary, IEat
        {
            public void Eat()
            {
                Console.WriteLine("Manager yemek yer");

            }

            public void GetSalary()
            {
                Console.WriteLine("Manager maaş alır");
            }

            public void Work()
            {
                Console.WriteLine("Manager çalışır");

            }
        }
    }

}
