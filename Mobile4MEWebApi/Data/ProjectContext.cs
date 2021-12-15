using Microsoft.EntityFrameworkCore;
using Mobile4MEWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.Data
{
  public class ProjectContext : DbContext
  {
    public ProjectContext(DbContextOptions options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Part>()
        .HasOne<Mobile>(p => p.Mobile)
        .WithMany(m => m.Parts)
        .HasForeignKey(p => p.MobileId)
        .OnDelete(DeleteBehavior.Cascade);

      builder.Entity<Mobile>()
        .HasOne<User>(m => m.User)
        .WithMany(u => u.Mobiles)
        .HasForeignKey(m => m.UserId)
        .OnDelete(DeleteBehavior.Cascade);

      builder.Entity<User>()
        .Property(u => u.Email)
        .IsRequired();

      builder.Entity<Role>()
        .Property(r => r.Name)
        .IsRequired();
    }

    internal void AddFailure(string v1, string v2)
    {
      throw new NotImplementedException();
    }

    public DbSet<Mobile> Mobiles { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
  }
}