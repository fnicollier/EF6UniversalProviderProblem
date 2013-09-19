using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/        
        public ActionResult Index()
        {
            Membership.CreateUser("tets", "testtesttesttest123");
            return View();
        }

    }
}
