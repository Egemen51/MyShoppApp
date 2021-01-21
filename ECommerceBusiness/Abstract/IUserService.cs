using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IUserService
    {
        User GetById(int id);
        void Create(User entitiy);
        void Update(User entitiy);
        void Delete(User entitiy);
    }
}
