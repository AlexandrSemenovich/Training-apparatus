using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Entity;

namespace Training_apparatus.Repository
{
    public class UserRepository: IUserRepository
    {
        private static List<User> _data = new List<User>();
        private int endIntex = 0;

        public int Add(User obj)
        {
            obj.Id = endIntex;
            endIntex +=1;
            _data.Add(obj);
            return obj.Id;
        }

        public void Update(User obj)
        {
            var user = _data.Find(c => c.Id == obj.Id);
            if (user != null)
                user.Name = obj.Name;
        }

      
        public void Remove(int id)
        {
            _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public User Find(int id)
        {
            return _data.Find(c => c.Id == id);
        }


        public List<User> FindAll()
        {
            return _data;
        }
    }
}
