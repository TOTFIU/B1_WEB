using Microsoft.EntityFrameworkCore;
//using B1_WEB.Domain;
using System.Numerics;
using B1_WEB.Models;

namespace B1_WEB.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Class_Value> Class_Values { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Decimal_bank_number> Decimals { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext>? options)
            : base(options)
        {
            Database.EnsureCreated();
        }
       
    }
}
