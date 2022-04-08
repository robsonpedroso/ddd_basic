using Domain.Contracts.External;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.External
{
    public class Maling: IMaling
    {
        public Maling()
        {
            

        }

        public bool Send(User user)
        {

            return true;
        }

        public User Get()
        {

            return new User();
        }
    }
}
