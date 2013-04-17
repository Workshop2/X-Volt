using System.Collections.Generic;
using System.Web.Http;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Web.Api._1._0
{
    public class NewsArticleController : ApiController
    {
        private INewsArticleRepository Repository { get; set; }

        public NewsArticleController(INewsArticleRepository repository)
        {
            Repository = repository;
        }

        // GET api/newsarticle
        public IEnumerable<NewsArticle> Get()
        {
            return Repository.List();
        }

        // GET api/newsarticle/5
        public NewsArticle Get(int id)
        {
            return Repository.Get(id);
        }

        // POST api/newsarticle
        public void Post([FromBody]NewsArticle value)
        {
            Repository.Save(value);
        }

        // PUT api/newsarticle/5
        public void Put(int id, [FromBody]NewsArticle value)
        {
            Repository.Save(value);
        }

        // DELETE api/newsarticle/5
        public void Delete(int id)
        {
            var toDelete = Repository.Get(id);
            Repository.Delete(toDelete);
        }
    }
}
