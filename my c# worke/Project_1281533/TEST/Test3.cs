using Project_1281533.MODELS;
using Project_1281533.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.TEST
{
    public class Test3
    {
        readonly IGenecriRepostory<PressureCooker> repo;
        public Test3(IGenecriRepostory<PressureCooker> repo)
        {
            this.repo = repo;
        }
        public void Run()
        {
            Console.WriteLine("Pressure Cookers");
            Console.WriteLine("========");
            
            repo.Add(new PressureCooker { Id = 1, ModelName = "Instant Pot Duo 7-in-1", Capasity = "10L", Price = 1000.99M, Color = "Red" });
            repo.AddRange(new PressureCooker[] {
                new PressureCooker { Id = 2, ModelName = "Prestige Deluxe Alpha Plus", Capasity = "14L", Price = 11000.55M, Color = "Blue" },
                 new PressureCooker { Id = 3, ModelName = "Hawkins Contura Pressure Cooker", Capasity = "3L", Price = 2050.99M, Color = "White" },
                  new PressureCooker { Id = 4, ModelName = "Philips Electric Pressure Cooker", Capasity = "5L", Price = 7000.50M, Color = "Black" },
                  new PressureCooker { Id = 5, ModelName = "WPC-MSM450", Capasity = "3.3L", Price = 1990.99M, Color = "Silver" }
            });
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"ModelName: {b.ModelName},Capasity:{b.Capasity},Price:{b.Price},Color:{b.Color}"));
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
        }
    }
}
