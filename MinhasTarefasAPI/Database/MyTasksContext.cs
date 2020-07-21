using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasTarefasAPI.Database
{
    public class MyTasksContext : DbContext
    {
        public MyTasksContext(DbContextOptions<MyTasksContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}
