using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCVM.Controllers
{
    public class ModelDemoController : Controller
    {
        //MVC 전부 사용
        // GET: ModelDemo
        public ActionResult Index()
        {
            var repo = new Models.BookRepositry();

            return View(repo.GetAll()); //List<Book>
        }
    }
}