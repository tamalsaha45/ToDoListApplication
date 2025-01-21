using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.TableModels;
using DAL.Interfaces;

namespace DAL.Repos
{
    public class UserRepo : Repo, IRepo<User, int, User>
    {
        public User Create(User obj)
        {
            db.Users.Add(obj);
            object value = db.SaveChanges();
            return obj;
        }

        public User Delete(int id)
        {
            var exobj = Get(id);
            db.Users.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return exobj;
        }
    }
}
