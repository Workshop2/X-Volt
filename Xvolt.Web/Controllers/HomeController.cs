using System.Web.Mvc;
using StructureMap;
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
