using erp_back_net.Entities.Client;
using erp_back_net.Entities.ClientOrder;
using erp_back_net.Entities.Product;
using erp_back_net.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace erp_back_net.Data;

public class ErpDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    
    public DbSet<ProductEntity> Products { get; set; }
    
    public DbSet<ClientEntity> Clients { get; set; }
    
    public DbSet<ClientOrderEntity> ClientOrders { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=:memory:");

}