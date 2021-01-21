using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
       

    }
}
