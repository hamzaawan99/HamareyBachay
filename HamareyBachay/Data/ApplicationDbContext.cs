using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HamareyBachay.Models;

namespace HamareyBachay.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Class>()
                .HasKey(c => new { c.ClassId, c.SectionId });
        }
        public DbSet<HamareyBachay.Models.Student> Student { get; set; }
        public DbSet<HamareyBachay.Models.Course> Course { get; set; }
        public DbSet<HamareyBachay.Models.Class> Class { get; set; }
    }
}
