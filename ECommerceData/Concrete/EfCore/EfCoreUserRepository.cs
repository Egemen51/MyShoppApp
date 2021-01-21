using ECommerce.Data.Abstract;
using ECommerceData.Concrete.EfCore;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.EfCore
{
    public class EfCoreUserRepository: EfCoreGenericRepository<User, MyShopAppContext>,IUserRepository
    {

    }
}
