using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure;
using Xvolt.Domain.Models;
using Xvolt.Web.Properties;
using Xvolt.Web.ViewModels.Home;

namespace Xvolt.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new IndexViewModel
            {
                NewsItems = new List<News>
                {
                    new News{ Title = "Test 1" },
                    new News{ Title = "Test 2" },
                },
                Shhh = CloudConfigurationManager.GetSetting("DbConnection") ?? "not set"
            };
            

            return View(model);
        }

    }
}
