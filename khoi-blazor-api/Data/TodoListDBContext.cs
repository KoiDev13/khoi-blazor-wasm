using khoi_blazor_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace khoi_blazor_api.Data
{
    public class TodoListDBContext : DbContext
    {
        public TodoListDBContext(DbContextOptions<TodoListDBContext> options) : base(options)
        { 
        }

        public DbSet<Entities.Task> Tasks { get; set; }

    }
}
