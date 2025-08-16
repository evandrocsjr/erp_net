namespace erp_back_net.Entities.Product.Dtos;

public class ProductUpdateDto
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public double Price { get; set; }
    
    public double Cost { get; set; }
}