using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Entity;
using Training_apparatus.Repository;

namespace Training_apparatus.Service
{
    class RegistrationService : IRegistrationService
    {
        private readonly UserRepository _repository;
        public RegistrationService()
        {
            //вынести в интерфейс можно IService
            _repository = new UserRepository();
        }

       public bool Registration(User user)
        {
            _repository.Add(user);
            _repository.Save();
            return true;
        }
    }
}
