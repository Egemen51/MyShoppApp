using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        void Create(Product entitiy);
        void Update(Product entitiy);
        void Delete(Product entitiy);
    }
}
