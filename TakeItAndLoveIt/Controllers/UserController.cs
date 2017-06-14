using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TakeItAndLoveIt.ViewModels;

namespace TakeItAndLoveIt.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/Users")]
        [HttpPost]
        public IHttpActionResult CreateUser(UsernameViewModel username)
        {
            return Ok();
        }
    }
}
