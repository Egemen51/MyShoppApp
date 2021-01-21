using ECommerceData.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Concrete.EfCore
{
    public class EfCoreCategoryRepository:EfCoreGenericRepository<Category,MyShopAppContext>,ICategoryRepository
    {
       
    }
}
