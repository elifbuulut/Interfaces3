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
            // Bir class birden fazla Interfacei implimente edebilir. 
            //--------------Çoklu implimentasyon Mantığı----------------------
            // Şöyle düşünelim . Bir şirket var. Şirkette 3 tip çalışan var.Robot, Worker(çalışan), Manager(Yönetici).IWorker diye interface
            //oluşturduğumuzu düşünelim. Bİr çalışan maaş alır, yemek yer,çalışır. Robot, Worker, Manager hepsi bir class olsun ve Iworker'ı 
            //implimente etsin. (eğer bu bir inherit(kalıtım,miras) olsaydı inherit etsin diyecektik.). Evet, bir worker, bir manager eat ,get salary, 
            //work gibi operasyonlar için uygundur ama bir robot uygun değildir. yemek yemez maaş almaz.AMA INTERFACE DE oluşturdugumuz şblon uymak
            //ilk kurallarımızdan dolayısıyla robot classı için Iworkerı implimente ettiğimizde o şablon oldugu gibi gelecek (GetSalary,Eat,Work)
            //Silemeyiz. O halde çözüm ÇOKLU İMPLEMENTASYONDUR. 
            // yeme içme çalışma operasyonlarından interface oluşturur,uz 
            /*
                interface IWorker
        {
            void GetSalary();
            void Eat();
            void Work();

        }
            */

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
