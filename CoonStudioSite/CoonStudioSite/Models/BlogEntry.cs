using System;
using System.ComponentModel.DataAnnotations;

namespace CoonGamesSite.Models
{
    public class BlogEntry
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
    }
}
