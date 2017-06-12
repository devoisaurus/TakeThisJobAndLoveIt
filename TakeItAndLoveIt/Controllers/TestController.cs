using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TakeItAndLoveIt.Controllers
{
    public class TestController : ApiController
    {
        [Route("api/JobLoveApp")]
        public List<string> GetAll()
        {
            return new List<string> {"I", "am", "only", "a", "test"};
        }

    }
}
