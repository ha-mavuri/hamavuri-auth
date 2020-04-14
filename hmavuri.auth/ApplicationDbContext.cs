using hmavuri.auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmavuri.auth
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationUserRole> UserRoles { get; set; }
        public DbSet<ApplicationUserClaim> UserClaims { get; set; }
        public DbSet<ApplicationUserLogin> UserLogins { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("Users");
            base.OnModelCreating(builder);
        }
    }
}
