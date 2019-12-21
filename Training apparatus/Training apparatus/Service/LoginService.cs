using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Entity;
using Training_apparatus.Repository;

namespace Training_apparatus.Service
{
    class LoginService : ILoginService
    {
        private readonly UserRepository _repository;
        public LoginService()
        {
            _repository = new UserRepository();
        }

        public bool Login(User user)
        {
            User userInRepository = _repository.FindAll().FirstOrDefault(c => c.Login == user.Login && c.Password == user.Password);
            if (userInRepository == null)
            {
                //_repository.Add(user);
                //_repository.Save();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
