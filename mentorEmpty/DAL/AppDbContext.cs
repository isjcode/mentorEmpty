using mentorEmpty.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace mentorEmpty.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<Trainers> Trainers { get; set; }
            public DbSet<Positions> Positions { get; set; }
            public DbSet<Events> Events { get; set; }
            public DbSet<Courses> Courses { get; set; }

        internal object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        public DbSet<Features> Features { get; set; }

            public DbSet<Pricings> Pricing { get; set; }
            public DbSet<Join> Join { get; set; } 
    }
}
