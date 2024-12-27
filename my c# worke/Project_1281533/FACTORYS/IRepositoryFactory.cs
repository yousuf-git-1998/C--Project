using Project_1281533.MODELS;
using Project_1281533.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.FACTORY
{
    public interface IRepositoryFactory
    {
        IGenecriRepostory<T>  GerRepo<T>() where T : EntityBase,new();
    }
}
