using khoi_blazor_api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace khoi_blazor_api.Data
{
    public class TodoListDBContext : IdentityDbContext<User, Role, Guid>
    {
        public TodoListDBContext(DbContextOptions<TodoListDBContext> options) : base(options)
        { 
        }

        public DbSet<Entities.Task> Tasks { get; set; }

    }
}
