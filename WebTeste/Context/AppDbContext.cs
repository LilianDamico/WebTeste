using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SeuNamespace // Substitua pelo seu namespace real
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Movimentation> Movimentation { get; set; }
        public DbSet<ContainerManager> ContainerManager { get; set; }
    }

    
}
