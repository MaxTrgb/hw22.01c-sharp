using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw22._01c_sharp
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        T GetById(int id);
    }
}
