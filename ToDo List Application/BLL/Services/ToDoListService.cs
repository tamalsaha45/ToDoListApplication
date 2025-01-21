using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using DAL.EF.TableModels;

namespace BLL.Services
{
    public class ToDoListService
    {
            static Mapper GetMapper()
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<ToDoList,ToDoListService>();
                    cfg.CreateMap<ToDoListService, ToDoList>();
                });
                return new Mapper(config);
            }

            public static bool Create(Services.ToDoListService obj)
            {
                var data = GetMapper().Map<ToDoList>(obj);
                return DataAccess.ToDoListData().Create(data);
            }

            public static List<Services.ToDoListService> Get()
            {
                var data = DataAccess.ToDoListData().Get();
                return GetMapper().Map<List<Services.ToDoListService>>(data);

            }
            public static Services.ToDoListService Get(int id)
            {
                var data = DataAccess.ToDoListData().Get(id);
                return GetMapper().Map<Services.ToDoListService>(data);
            }

            public static bool Update(Services.ToDoListService obj)
            {
                var data = GetMapper().Map<ToDoList>(obj);
                return DataAccess.ToDoListData().Update(data);

            }

            public static bool Delete(int id)
            {
                return DataAccess.ToDoListData().Delete(id);

            }
        }
}
