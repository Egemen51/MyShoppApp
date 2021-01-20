using ECommerceData.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Concrete.EfCore
{
    class EfCoreProductRepository:EfCoreGenericRepository<Product,MyShopAppContext>
    {
       
    }
}
