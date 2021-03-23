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
        public DbSet<HamareyBachay.Models.Student> Student { get; set; }
        public DbSet<HamareyBachay.Models.Course> Course { get; set; }
    }
}
