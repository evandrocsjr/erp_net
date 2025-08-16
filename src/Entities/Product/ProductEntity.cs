namespace erp_back_net.Entities.Product;

public class ProductEntity : BaseEntity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public double Price { get; set; }
    
    public double Cost { get; set; }
}