using ECommerce.Business.Abstract;
using ECommerce.Data.Abstract;
using ECommerceData.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
   
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public void Create(User entitiy)
        {
            _userRepository.Create(entitiy);
        }

        public void Delete(User entitiy)
        {
            _userRepository.Delete(entitiy);
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User entitiy)
        {
            _userRepository.Update(entitiy);
        }
    }
}
