using System.Collections.Generic;
using System.Web.Mvc;
using StructureMap;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;
using Xvolt.Domain.Services.Interfaces;
using Xvolt.Web.ViewModels.Home;

namespace Xvolt.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsService _newsService;

        public HomeController(INewsService newsService)
        {
            _newsService = newsService;
        }


        //
        // GET: /Home/

        public ActionResult Index()
        {
            IEnumerable<NewsArticle> articles = _newsService.GetNewsArticles();
            var viewModel = new IndexViewModel {NewsArticles = articles};

            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (_newsService != null)
            {
                _newsService.Dispose();
            }
        }
    }
}
