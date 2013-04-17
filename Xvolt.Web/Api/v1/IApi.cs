using System.Collections.Generic;
using System.Web.Http;

namespace Xvolt.Web.Api.v1
{
    public interface IApi<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Post([FromBody] T value);
        void Put(int id, [FromBody] T value);
        void Delete(int id);
    }
}