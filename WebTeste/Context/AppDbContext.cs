using System;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : Dbcontext
{
    public AppDbContext(DbContextOptionsd<appDbContext> options) : base(options)
    {

    }

    public DbSet<MovimentationType> MovimentationType { get; set; }
    public DbSet<Movimentation> Movimentation { get; set; }
    public DbSet ContainerManager { get; set; }
}
