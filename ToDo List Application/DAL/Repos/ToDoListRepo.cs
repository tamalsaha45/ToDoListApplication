using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.TableModels;
using DAL.Interfaces;

namespace DAL.Repos
{
    public class ToDoListRepo : Repo, IRepo<ToDoList, int, ToDoList>
    {
        public ToDoList Create(ToDoList obj)
        {
            db.ToDoLists.Add(obj);
            object value = db.SaveChanges();
            return obj;
        }

        public ToDoList Delete(int id)
        {
            var exobj = Get(id);
            db.ToDoLists.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<ToDoList> Get()
        {
            return db.ToDoLists.ToList();
        }

        public ToDoList Get(int id)
        {
            return db.ToDoLists.Find(id);
        }

        public ToDoList Update(ToDoList obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return exobj;
        }
    }
}