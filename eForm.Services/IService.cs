using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Services
{
    public interface IService<T>
    {
        T GetById(string id);
        IList<T> FindAll();
        string Create(T o);
        bool Update(T o);
        bool Delete(string id);
    }

}
