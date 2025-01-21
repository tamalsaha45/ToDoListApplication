using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.EF.TableModels;
using DAL;

namespace BLL.Services
{
    public class UserService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserService>();
                cfg.CreateMap<UserService, User>();
            });
            return new Mapper(config);
        }

        public static bool Create(Services.UserService obj)
        {
            var data = GetMapper().Map<User>(obj);
            return DataAccess.UserData().Create(data);
        }

        public static List<Services.UserService> Get()
        {
            var data = DataAccess.UserData().Get();
            return GetMapper().Map<List<Services.UserService>>(data);

        }
        public static Services.UserService Get(int id)
        {
            var data = DataAccess.UserData().Get(id);
            return GetMapper().Map<Services.UserService>(data);
        }

        public static bool Update(Services.UserService obj)
        {
            var data = GetMapper().Map<User>(obj);
            return DataAccess.UserData().Update(data);

        }

        public static bool Delete(int id)
        {
            return DataAccess.UserData().Delete(id);

        }
    }
}
