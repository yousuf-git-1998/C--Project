﻿using Project_1281533.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281533.REPOSITORIES
{
    public class GenericRepositoryImpl<T> : IGenecriRepostory<T> where T : EntityBase, new()
    {
        private readonly List<T> items = new List<T>();
        public IEnumerable<T> Get()
        {
            return items;
        }

        public T Get(int id)
        {
           return items.First(x=>x.Id == id);
        }
        public void Add(T entity)
        {
            items.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            items.AddRange(entities);
        }

        public void Delete(int id)
        {
          var item =  items.First(x => x.Id == id);
            items.Remove(item);
        }

        

        public void Update(T entity)
        {
          int index=items.FindIndex(x=>x.Id == entity.Id);
            items.RemoveAt(index);
            items.Insert(index, entity);
        }
    }
}
