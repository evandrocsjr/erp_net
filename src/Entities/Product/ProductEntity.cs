namespace erp_back_net.Entities.Product;

public class ProductEntity : BaseEntity
{
    public required string Name { get; set; }
    
    public string? Description { get; set; }
    
    public required double Price { get; set; }
    
    public required double Cost { get; set; }
}