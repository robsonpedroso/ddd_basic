using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Service
{
    public interface IUserService
    {
        User Save(User user);
    }
}
