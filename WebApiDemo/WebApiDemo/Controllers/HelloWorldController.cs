using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{

    // /api/HelloWorld/
    public class HelloWorldController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "안녕하세요.", "반갑습니다." };
        }

        // GET:id
        public string Get(int id)
        {
            return "입력한 값 : " + id.ToString();
        }
    }
}
