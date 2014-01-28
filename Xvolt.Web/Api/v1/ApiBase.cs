using System.Collections.Generic;
using System.Web.Http;

namespace Xvolt.Web.Api.v1
{
    /// <summary>
    /// Api base. Contains standard layout for a CRUD api with Authorize flags
    /// </summary>
    /// <typeparam name="T">T is the class to perform CRUD operations on</typeparam>
    public abstract class ApiBase<T> : ApiController, IApi<T> where T : class
    {
        public abstract IEnumerable<T> Get();
        public abstract T Get(int id);

        [Authorize]
        public abstract void Post(T value);
        [Authorize]
        public abstract void Put(int id, T value);
        [Authorize]
        public abstract void Delete(int id);
    }
}