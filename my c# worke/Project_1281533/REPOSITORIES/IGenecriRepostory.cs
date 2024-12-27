﻿using Project_1281533.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.REPOSITORIES
{
    public interface IGenecriRepostory<T> where T : EntityBase, new()
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);

    }
}
