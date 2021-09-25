using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManger.Shared;

namespace TaskManger.Server.Data
{
    public class TaskMangerServerContext : DbContext
    {
        public TaskMangerServerContext (DbContextOptions<TaskMangerServerContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManger.Shared.TaskItem> TaskItem { get; set; }
    }
}
