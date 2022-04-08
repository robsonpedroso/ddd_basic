using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Application
{
    public interface IUserApplication
    {
        DTO.User Save(DTO.User user);
    }
}
