using System;

namespace NETBlog.Models
{
    public class Commentary
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string CommentaryContent { get; set; }
    }
}