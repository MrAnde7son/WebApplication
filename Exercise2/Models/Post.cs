using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string AuthorName { get; set; }
        public string SiteUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public byte[] Video { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}