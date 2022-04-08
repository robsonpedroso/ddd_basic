using DTO = Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service;
using Domain.Contracts.Application;
using Domain.Contracts.Service;

namespace Application
{
    public class UserApplication: IUserApplication
    {
        IUserService _userService { get; set; }
        public UserApplication(IUserService userService)
        {
            _userService = userService;
        }
        
        public DTO.User Save(DTO.User user)
        {
            if (!user.IsValid())
                throw new Exception("Esse usuário não é válido");

            var usrSaved = _userService.Save(new Domain.Model.User(user));

            return new DTO.User(usrSaved);
        }
    }
}
