using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    public class AppDbContext : DbContext
    {
        #region AppDbContext
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database = EF01; Trusted_Connection = True;TrustServerCertificate=True");
        //}
        //public DbSet<Book> Books { get; set; }

        //public DbSet<Authors> Authors { get; set; }

        //public DbSet<Category> Categories { get; set; } 
        #endregion


    }
}
