using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.TableModels;

namespace DAL.EF
{
    internal class PContext : DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
