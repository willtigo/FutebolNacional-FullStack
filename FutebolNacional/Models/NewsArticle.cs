using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolNacional.Models
{
    //public class NewsArticle
    //{
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    public string Url { get; set; }
    //    public DateTime PublishedAt { get; set; }
    //    public string SourceName { get; set; }
    //}
    public class NewsArticle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime PublishedAt { get; set; }
        public string SourceName { get; set; } // No GNews é 'source' -> 'name'
        public string Image { get; set; }      // O GNews traz ótimas imagens ('image')
    }
}
