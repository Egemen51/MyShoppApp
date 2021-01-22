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
            _productRepository.Create(entitiy);
        }

        public void Delete(Product entitiy)
        {
            _productRepository.Delete(entitiy);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entitiy)
        {
            _productRepository.Update(entitiy);
        }
    }
}
