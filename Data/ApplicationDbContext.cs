using Microsoft.EntityFrameworkCore;
using Veeb_Naidis.Models;

namespace Veeb_Naidis.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ContactData> ContactDatas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
