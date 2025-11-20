using Microsoft.EntityFrameworkCore;
using template_form_backed.Domain.Users;

namespace template_form_backed.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserDetail> Users { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
