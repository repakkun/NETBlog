using System;

namespace NETBlog.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public Tag Tag { get; set; }
        public User User { get; set; }
    }
}