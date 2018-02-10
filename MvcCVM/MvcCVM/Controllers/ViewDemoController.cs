using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCVM.Controllers
{
    public class ViewDemoController : Controller
    {
        //뷰 테이블 출력
        // GET: ViewDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}