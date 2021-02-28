using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //builder.UseSqlServer("Server=DESKTOP-KJI08HO\\KONSEK;Database=album;Trusted_Connection=True;Integrated Security=False");

            optionsBuilder.UseSqlServer("Server =(localdb)\\MSSQLLocalDB; Database=album; Trusted_Connection = True; Integrated Security = False", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });

            base.OnConfiguring(optionsBuilder);
        }
    }
}
