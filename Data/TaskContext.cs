using Microsoft.EntityFrameworkCore;
using TaskModel = TaskManagerAPI.Models.Task;

namespace TaskManagerAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }

    }
}