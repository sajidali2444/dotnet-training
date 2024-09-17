using DotnetAPI.Entities;
using Microsoft.EntityFrameworkCore;



//orm => Object Relation Mapping
// Entity Framework -> ORM
// Entity Framework Core
// Dapper

namespace DotnetAPI;

public class AppDBContext : DbContext
{
    public virtual DbSet<City> Cities { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Properties> Properties { get; set; }
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
}