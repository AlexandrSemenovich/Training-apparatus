using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Training_apparatus.Models.Entity;
namespace Training_apparatus.Repository
{
    public interface IUserRepository
    {
        int Add(User user);
        void Remove(int id);
        User Find(int id);
        List<User> FindAll();
        void Update(User obj);
        void Save();
    }
}
