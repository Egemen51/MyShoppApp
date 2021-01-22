using ECommerce.Business.Abstract;
using ECommerceData.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
       
        public void Create(Category entitiy)
        {
            _categoryRepository.Create(entitiy);
        }

        public void Delete(Category entitiy)
        {
            _categoryRepository.Delete(entitiy);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category entitiy)
        {
            _categoryRepository.Update(entitiy);
        }
    }
}
