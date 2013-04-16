using System.Web.Mvc;
using StructureMap;
using Xvolt.Domain.Repositories;
using Xvolt.Web.ViewModels.Home;

namespace Xvolt.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(INewsArticleRepository repository)
        {
            
        }



        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = ObjectFactory.GetInstance<IndexViewModel>();
            

            return View(model);
        }

    }
}
