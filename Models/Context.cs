using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Star_Academy.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Form> Form { get; set; }
    }
}
