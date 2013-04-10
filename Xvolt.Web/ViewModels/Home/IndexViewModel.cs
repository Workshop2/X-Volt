using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<News> NewsItems { get; set; }
        public string Shhh { get; set; }
    }
}