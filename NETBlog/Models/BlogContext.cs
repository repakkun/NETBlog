using Microsoft.EntityFrameworkCore;

namespace NETBlog.Models
{
    public sealed class BlogContext : DbContext
    {
        /// Ссылки на таблицу
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        
        // Логика взаимодействия с таблицами в БД
        public BlogContext(DbContextOptions<BlogContext> options)  : base(options)
        {
            Database.EnsureCreated();
        }
    }
  
}