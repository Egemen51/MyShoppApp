using ECommerce.Business.Abstract;
using ECommerceData.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
