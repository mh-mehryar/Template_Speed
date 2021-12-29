using Microsoft.EntityFrameworkCore;

public class Connect : DbContext
{
    public DbSet<Products> product { get; set; }
    public DbSet<Products> product_1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder db)
    {
        db.UseSqlServer("Data Source =.;Initial Catalog = Bike_Shop;Integrated Security=true");
    }
}