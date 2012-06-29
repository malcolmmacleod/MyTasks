using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TomatoTimer.Domain;
using TomatorTimer.Service;

namespace TomatoTimer.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Tasks/

        public ActionResult Index()
        {


            return View();
        }

    }
}
