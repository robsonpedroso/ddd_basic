using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.External
{
    public interface IMaling
    {
        bool Send(User user);
    }
}
