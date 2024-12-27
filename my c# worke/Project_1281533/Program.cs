using Project_1281533.FACTORYS;
using Project_1281533.MODELS;
using Project_1281533.TEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533
{
    internal class Program
    {
        static void Main()
        {
            var f = new RepositoryFactoryimpl();
            Console.WriteLine("Contructor dependency injection");
            Test1 di1 = new Test1(f);
            di1.Run();
            Console.WriteLine("=================");
            Console.WriteLine("Method dependency injection");
            Test2 di2 = new Test2();
            di2.Run(f);
            Console.WriteLine();
            Console.WriteLine("Repository Dependency injection");
            Console.WriteLine("=================");
            Test3 di3 = new Test3(f.GerRepo<PressureCooker>());
            di3.Run();
            Test4 di4 = new Test4(f.GerRepo<MicroOven>());
            di4.Run();
            Console.ReadLine();
        }
    }
}
