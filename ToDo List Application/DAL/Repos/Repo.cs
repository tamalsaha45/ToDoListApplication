using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL.Repos
{
    internal class Repo
    {
        protected PContext db;

        internal Repo()
        {
            db = new PContext();
        }
    }
}
