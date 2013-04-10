using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xvolt.Web.Models;

namespace Xvolt.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var tempData = new List<News>
            {
                new News{ Title = "Test 1" },
                new News{ Title = "Test 2" },
            };

            return View(tempData);
        }

    }
}
