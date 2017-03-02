using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace git.Controllers
{
    public class HomeController : Controller
    {
        TOPEntities db = new TOPEntities();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(db.Blogs.ToList());
        }
	}
}