using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoTimer.Domain.Repository
{
    public interface IRepository <T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Add(T item);

        void Update(int id, T item);

        void Delete(int id);
    }
}
