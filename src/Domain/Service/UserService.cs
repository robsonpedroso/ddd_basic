using Domain.Contracts.Repository;
using Domain.Contracts.Service;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class UserService:IUserService
    {
        IUserRepository _userRepository { get; set; }
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Save(User user)
        {
            var db = _userRepository.Save(user);
            return user;
        }
    }
}
