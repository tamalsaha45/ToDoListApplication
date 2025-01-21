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
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
            [HttpGet]
            [Route("all")]

            public HttpResponseMessage Get()
            {
                try
                {
                    var data = UserService.Get();
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
                    var data = UserService.Get(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
                }
            }

            [HttpPost]
            [Route("Create")]

            public HttpResponseMessage Create(UserDTO obj)
            {
                try
                {
                    var data = UserService.Create(obj);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
                }
            }

            [HttpPost]
            [Route("Update")]

            public HttpResponseMessage Update(UserDTO obj)
            {
                try
                {
                    var data = UserService.Update(obj);
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
                    var data = UserService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
                }
            }
        }
}
