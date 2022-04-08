using Domain.Contracts.External;
using Domain.Contracts.Repository;
using Domain.Model;
using Domain.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly IMaling _mailing;
        AppConfig _appConfig;
        public UserRepository(IMaling mailing, AppConfig appConfig)
        {
            _mailing = mailing;
            _appConfig = appConfig;
        }
        public User Save(User user)
        {
            //salva no banco

            _mailing.Send(user);
            var x = _appConfig.User;

            /// salvar no log
            return user;
        }
    }
}
