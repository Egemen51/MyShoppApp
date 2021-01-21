using ECommerceData.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
