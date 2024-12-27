using Project_1281533.FACTORY;
using Project_1281533.MODELS;
using Project_1281533.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.FACTORYS
{
    public class RepositoryFactoryimpl : IRepositoryFactory
    {
        public IGenecriRepostory<T> GerRepo<T>() where T : EntityBase, new()
        {
          return new GenericRepositoryImpl<T>();
        }
    }
}
