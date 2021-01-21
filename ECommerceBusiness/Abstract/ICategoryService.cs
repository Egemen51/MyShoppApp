using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        void Create(Category entitiy);
        void Update(Category entitiy);
        void Delete(Category entitiy);
    }
}
