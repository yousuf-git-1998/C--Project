using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.MODELS
{
    public class MicroOven : EntityBase
    {
        public string ModelName { get; set; }
        public string Capasity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}
