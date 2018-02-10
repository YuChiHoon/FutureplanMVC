using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCVM.Controllers
{
    public class ControllerDemoController : Controller
    {
        //컨트롤러 테이블 출력
        // GET: ControllerDemo
        public string Index()
        {
            string strData = "<table border =\"1\">" + 
                "<tr><td>1</td><td>ASP.NET Web Forms</td></tr>" + 
                "<tr><td>2</td><td>ASP.NET MVC</td></tr></table>";
            return strData;
        }
    }
}