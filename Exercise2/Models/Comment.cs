using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Subject { get; set; }
        public string AuthorName { get; set; }
        public string SiteUrl { get; set; }
        public string Content { get; set; }
        public virtual Post Post { get; set; }
    }
}