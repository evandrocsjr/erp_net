namespace erp_back_net.Entities.ClientOrder.Dtos;

public class ClientOrderUpdateDto
{
    public required long ClientId { get; set; }
    
    public required long[] ProductIds { get; set; }
}