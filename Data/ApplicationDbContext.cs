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
        public DbSet<Notenverwaltung.Models.Module> Module { get; set; }
        public DbSet<Notenverwaltung.Models.Profession> Profession { get; set; }
        public DbSet<Notenverwaltung.Models.SchoolClass> SchoolClass { get; set; }
        public DbSet<Notenverwaltung.Models.User> User { get; set; }
    }
}
