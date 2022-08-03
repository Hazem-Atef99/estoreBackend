using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estore.Models
{
    public class productContext : DbContext
    {
       




            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TD6O5GK\\SQLEXPRESS;Initial Catalog=estoreDb;Integrated Security=True");
        }


        public DbSet<product> products { get; set; }
    } 

}
