using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            // var t = Categories;
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=DESKTOP-HA42MEA\SQLEXPRESS; initial catalog=EFCore;persist security info=True;user id=sa;password=Sql@1234; MultipleActiveResultSets=True; App=EntityFramework");
                //  optionsBuilder.UseSqlServer(@"Data Source=KAPIL\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=true");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
