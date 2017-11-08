using ComicsStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicsStores.BL.IRepository
{
    
    interface IRepository<T>:IDisposable where T : class
    {

        void Save();
        void Delete(int id);
        void Update(T item);
        void Create(T item);
        IEnumerable<T> GetList();
        T GetItem(int id);

    } 
}