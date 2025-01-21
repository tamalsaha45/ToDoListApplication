using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace ToDo_List_Application.Controllers
{
    [RoutePrefix("api/ToDoList")]
    public class ToDoListController : ApiController
    {
        [HttpGet]
        [Route("all")]

        public HttpResponseMessage Get()
        {
            try
            {
                var data = ToDoListService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("{Id}")]

        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = ToDoListService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("Create")]

        public HttpResponseMessage Create(ToDoListDTO obj)
        {
            try
            {
                var data = ToDoListService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("Update")]

        public HttpResponseMessage Update(ToDoListDTO obj)
        {
            try
            {
                var data = ToDoListService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("delete/{Id}")]

        public HttpResponseMessage Create(int Id)
        {
            try
            {
                var data = ToDoListService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
