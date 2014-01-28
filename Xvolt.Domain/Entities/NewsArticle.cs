using System;
using System.Collections.Generic;

namespace Xvolt.Domain.Entities
{
    public class NewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime OriginalPublishDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public User Author { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public NewsContent Content { get; set; }
        public bool Visible { get; set; }

        public NewsArticle()
        {
            Images = new List<Image>();
        }
    }
}