using System.ComponentModel.DataAnnotations;
using erp_back_net.Entities.Client;
using erp_back_net.Entities.Product;

namespace erp_back_net.Entities.ClientOrder;

public class ClientOrderEntity : BaseEntity
{
    public required ClientEntity Client { get; set; }

    [MinLength(1)]
    public required List<ProductEntity> Products { get; set; } = [];
}