using Microsoft.EntityFrameworkCore;

namespace Fix.Models.Repository
{
   
        public class EFDbContext : DbContext
        {
        public DbSet<Category> Items { get; set; } = null!;
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { ItemID = 1, Art = "Liberty Artist", Byd = 2.03f, Price = 8240.50f, Dat =new DateTime(2022,7,12,14,00,00)},
                    new Category { ItemID = 2, Art = "Digital Crypto Artwork", Byd = 2.03f, Price = 7200.50f, Dat = new DateTime(2022, 7, 26,22,00,00) },
                    new Category { ItemID = 3, Art = "Blockchain Item One", Byd = 3.64f, Price = 6600.00f, Dat = new DateTime(2022, 7, 28,11,00,0) },
                    new Category { ItemID = 4, Art = "Virtual Currency Art", Byd = 2.44f, Price = 8800.50f, Dat = new DateTime(2022, 7, 14,17,0,0) },
                    new Category { ItemID = 5, Art = "Digital Art Item", Byd = 2.50F, Price = 8400.50F, Dat = new DateTime(2022, 7, 16,21,0,0) },
                    new Category { ItemID = 6, Art = "Blockchain Music Design", Byd = 2.44F, Price = 8200.50F, Dat = new DateTime(2022, 7, 18,9,0,0) }
            );
        }





    }
    
}


