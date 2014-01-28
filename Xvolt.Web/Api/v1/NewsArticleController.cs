using System.Collections.Generic;
using System.Web.Http;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Web.Api.v1
{
    public class NewsArticleController : ApiBase<NewsArticle>
    {
        private INewsArticleRepository Repository { get; set; }

        public NewsArticleController(INewsArticleRepository repository)
        {
            Repository = repository;
        }

        // GET api/newsarticle
        public override IEnumerable<NewsArticle> Get()
        {
            return Repository.List();
        }

        // GET api/newsarticle/5
        public override NewsArticle Get(int id)
        {
            return Repository.Get(id);
        }

        // POST api/newsarticle override
        public override void Post([FromBody]NewsArticle value)
        {
            Repository.Save(value);
        }

        // PUT api/newsarticle/5
        public override void Put(int id, [FromBody]NewsArticle value)
        {
            Repository.Save(value);
        }

        // DELETE api/newsarticle/5
        public override void Delete(int id)
        {
            var toDelete = Repository.Get(id);
            Repository.Delete(toDelete);
        }
    }
}
