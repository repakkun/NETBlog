using System;
using System.Linq;
namespace NETBlog.Models
{
    public class SampleData
    {
        public static void Initialize(BlogContext context)
        {
            if (context.Users.Any()) return;
            context.Users.AddRange(
                new User
                {
                    Id = new Guid(),
                    UserName = "Test",
                    JoinDate = DateTime.Now
                }
            );
            context.SaveChanges();
        }
    }
}