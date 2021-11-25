using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Notenverwaltung.Models;

namespace Notenverwaltung.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Notenverwaltung.Models.Student> Student { get; set; }
        public DbSet<Notenverwaltung.Models.Teacher> Teacher { get; set; }
        public DbSet<Notenverwaltung.Models.Admin> Admin { get; set; }
    }
}
