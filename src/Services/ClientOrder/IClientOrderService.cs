using erp_back_net.Entities.ClientOrder.Dtos;

namespace erp_back_net.Services.ClientOrder;

public interface IClientOrderService
{
    Task<ClientOrderDto> CreateAsync(ClientOrderCreateDto dto);
    
    Task<ClientOrderDto> GetByIdAsync(long id);
    
    Task<ClientOrderDto> UpdateAsync(long id, ClientOrderUpdateDto dto);

    Task DeleteAsync(long id);
}