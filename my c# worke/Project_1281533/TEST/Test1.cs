using Project_1281533.FACTORY;
using Project_1281533.MODELS;
using Project_1281533.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.TEST
{
     public class Test1
    {

        readonly IRepositoryFactory factory;
        public Test1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public  void Run()
        {
            Console.WriteLine("Pressure Cookers");
            Console.WriteLine("========");
            IGenecriRepostory<PressureCooker> repo = this.factory.GerRepo<PressureCooker>();
            repo.Add(new PressureCooker { Id = 1, ModelName = "Instant Pot Duo 7-in-1", Capasity = "10L", Price = 1000.99M, Color = "Red" });
            repo.AddRange(new PressureCooker[] {
                new PressureCooker { Id = 2, ModelName = "Prestige Deluxe Alpha Plus", Capasity = "14L", Price = 11000.55M, Color = "Blue" },
                 new PressureCooker { Id = 3, ModelName = "Hawkins Contura Pressure Cooker", Capasity = "3L", Price = 2050.99M, Color = "White" },
                  new PressureCooker { Id = 4, ModelName = "Philips Electric Pressure Cooker", Capasity = "5L", Price = 7000.50M, Color = "Black" },
                  new PressureCooker { Id = 5, ModelName = "WPC-MSM450", Capasity = "3.3L", Price = 1990.99M, Color = "Silver" }
            }) ;
            repo.Get()
                .ToList()
                .ForEach(b =>  Console.WriteLine($"ModelName: {b.ModelName},Capasity:{b.Capasity},Price:{b.Price},Color:{b.Color}"));
            Console.WriteLine("=======update=======");
            //update
            var pressureCooker = repo.Get(2);
            pressureCooker.Price = 899.99M;
            repo.Update(pressureCooker);
            repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"ModelName: {b.ModelName},Capasity:{b.Capasity},Price:{b.Price},Color:{b.Color}"));
            Console.WriteLine("=======delete======");
            //delete
            repo.Delete(3);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"ModelName: {b.ModelName},Capasity:{b.Capasity},Price:{b.Price},Color:{b.Color}"));

            Console.WriteLine("Mcro Oven");
            IGenecriRepostory<MicroOven> repoM = factory.GerRepo<MicroOven>();
            repoM.Add(new MicroOven { Id = 1, ModelName = "Panasonic", Capasity = "23L", Price = 9499.99M, Color = "Space Gray" });
            repoM.AddRange(new MicroOven[]
            {
                new MicroOven { Id=2,ModelName= "Sharp",Capasity="20L",Price = 6999.99M,Color = "Mate Black" },
                 new MicroOven { Id=3,ModelName= "Samsung Smart Microwave",Capasity=" 28L",Price =22900.00M,Color = "Orange" }
            });
            repoM.Get()
                .ToList()
                .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));
            Console.WriteLine("===update 2====");
            //update
            var microOven = repoM.Get(1);
            microOven.Price = 559.90M;
            repoM.Update(microOven);
            repoM.Get()
               .ToList()
               .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));
            Console.WriteLine("======delete 2=======");
            //delete
            repoM.Delete(1);
            repoM.Get()
               .ToList()
               .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));

        }
    }
}
