using Sakura.AspNetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAdmin.Domain.BaseDomain
{
    public interface IService<T> where T : class
    {
        T Get(int pkId, object obj = null);
        PagedList<IEnumerable<T>, T> GetList(Dictionary<string, object> condition, object obj = null);
        int Create(T t, object obj = null);
        bool Remove(T t, object obj = null);
        bool Modeify(T t, object obj = null);
    }
}
