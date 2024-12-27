using Project_1281533.MODELS;
using Project_1281533.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.TEST
{
    public class Test4
    {
        readonly IGenecriRepostory<MicroOven> repo;
        public Test4(IGenecriRepostory<MicroOven> repo)
        {
            this.repo = repo;
        }
        public void Run()
        {
            Console.WriteLine("Mcro Oven");
            
            repo.Add(new MicroOven { Id = 1, ModelName = "Panasonic", Capasity = "23L", Price = 9499.99M, Color = "Space Gray" });
            repo.AddRange(new MicroOven[]
            {
                new MicroOven { Id=2,ModelName= "Sharp",Capasity="20L",Price = 6999.99M,Color = "Mate Black" },
                 new MicroOven { Id=3,ModelName= "Samsung Smart Microwave",Capasity=" 28L",Price =22900.00M,Color = "Orange" }
            });
            repo.Get()
                .ToList()
                .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));
            Console.WriteLine("===update 2====");
            //update
            var microOven = repo.Get(1);
            microOven.Price = 559.90M;
            repo.Update(microOven);
            repo.Get()
               .ToList()
               .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));
            Console.WriteLine("======delete 2=======");
            //delete
            repo.Delete(1);
            repo.Get()
               .ToList()
               .ForEach(p => Console.WriteLine($"Id:{p.Id},ModelName: {p.ModelName},Capasity:{p.Capasity},Price:{p.Price},Color:{p.Color}"));
        }
    }
}
