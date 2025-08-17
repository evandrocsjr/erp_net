using erp_back_net.Entities.Client.Dtos;
using erp_back_net.Entities.Product.Dtos;

namespace erp_back_net.Entities.ClientOrder.Dtos;

public class ClientOrderDto : BaseDto
{
    public required ClientDto Client { get; set; }

    public required List<ProductDto> Products { get; set; } = [];
}