using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<ToDoList, int, bool> ToDoListData()
        {
            return new ToDoListRepo();
        }

        public static IRepo<User, int, bool>UserData()
        {

            return new UserRepo();
        }
        }
    }
}
