using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure;
using StructureMap;
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
            var model = ObjectFactory.GetInstance<IndexViewModel>();
            

            return View(model);
        }

    }
}
