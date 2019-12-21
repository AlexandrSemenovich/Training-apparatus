using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Entity;

namespace Training_apparatus.Service
{
    public interface IRegistrationService
    {
        bool Registration(User user);
    }
}
