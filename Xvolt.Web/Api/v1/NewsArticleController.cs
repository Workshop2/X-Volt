using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StructureMap;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Web.Api.v1
{
    public class NewsArticleController : ApiController
    {
        // GET api/newsarticle
        public IEnumerable<NewsArticle> Get()
        {
            var repository = ObjectFactory.GetInstance<INewsArticleRepository>();
            return repository.List();
        }

        // GET api/newsarticle/5
        public NewsArticle Get(int id)
        {
            var repository = ObjectFactory.GetInstance<INewsArticleRepository>();
            return repository.Get(id);
        }

        // POST api/newsarticle
        public void Post([FromBody]NewsArticle value)
        {
            var repository = ObjectFactory.GetInstance<INewsArticleRepository>();
            repository.Save(value);
        }

        // PUT api/newsarticle/5
        public void Put(int id, [FromBody]NewsArticle value)
        {
            var repository = ObjectFactory.GetInstance<INewsArticleRepository>();
            repository.Save(value);
        }

        // DELETE api/newsarticle/5
        public void Delete(int id)
        {
            var repository = ObjectFactory.GetInstance<INewsArticleRepository>();
            var toDelete = repository.Get(id);
            repository.Delete(toDelete);
        }
    }
}
