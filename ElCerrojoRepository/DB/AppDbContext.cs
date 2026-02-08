using ElCerrojoRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.DB
{
    public class AppDbContext : DbContext
    {
        //private ConnectionDB connectionDb = new ConnectionDB();

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<SaleDetail> DetailSale => Set<SaleDetail>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones de entidades
            modelBuilder.Entity<Product>().Property(u => u.BarCode).HasMaxLength(30);
            modelBuilder.Entity<Product>().HasIndex(u => u.BarCode).IsUnique()
                                                                   .HasFilter("[BarCode] IS NOT NULL");

            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Category)
                        .WithMany(c => c.Products)
                        .HasForeignKey(p => p.CategoryId)
                        .OnDelete(DeleteBehavior.SetNull);
            // -------------------------
            // Seeding de datos iniciales
            // -------------------------
            //modelBuilder.Entity<Brand>().HasData(
            //    new Brand { Id = 1, Name = "Sin marca" },
            //    new Brand { Id = 2, Name = "Generica", ContactName = "Gonzalo Lopez", Phone = 3415641108 },
            //    new Brand { Id = 3, Name = "XYZ", ContactName = "Franquito Castell", Phone = 3415555555 }
            //);

            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = 1, Name = "Herramientas" },
            //    new Category { Id = 2, Name = "Materiales"},
            //    new Category { Id = 3, Name = "Otros" }
            //);

            //modelBuilder.Entity<Product>().HasData(
            //    new Product { Id = 1, Name = "Martillo Generico", CategoryId = 1, BrandId = 2, Price = 1000.01m, BuyPrice = 500.02m, Stock = 50, BarCode = "11111111",  },
            //    new Product { Id = 2, Name = "Taladro X", CategoryId = 1, BrandId = 3, Price = 90000.99m, BuyPrice = 49999.99m, Stock = 55, BarCode = "9999999", },
            //    new Product { Id = 3, Name = "Destornillador", CategoryId = 1, BrandId = 1, Price = 800.12m, BuyPrice = 100.00m, Stock = 10, BarCode = "12121212", },
            //    new Product { Id = 4, Name = "Arena", CategoryId = 2, BrandId = 1, Price = 999.99m, BuyPrice = 555.00m, Stock = 10, BarCode = "5555555", },
            //    new Product { Id = 5, Name = "Cables", CategoryId = 3, BrandId = 2, Price = 50m, BuyPrice = 10m, Stock = 10, BarCode = "0000000001", }
            //);
        }
    }
}
