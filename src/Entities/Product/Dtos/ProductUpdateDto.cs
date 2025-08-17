namespace erp_back_net.Entities.Product.Dtos;

public class ProductUpdateDto
{
    public required string Name { get; set; }
    
    public string? Description { get; set; }
    
    public required double Price { get; set; }
    
    public required double Cost { get; set; }
}