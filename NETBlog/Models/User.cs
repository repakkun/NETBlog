using System;

namespace NETBlog.Models
{
    /// <summary>
    /// модель пользователя в блоге
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}