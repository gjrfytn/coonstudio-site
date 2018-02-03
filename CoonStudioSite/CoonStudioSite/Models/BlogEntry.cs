using System;

namespace CoonGamesSite.Models
{
    public class BlogEntry
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
    }
}
