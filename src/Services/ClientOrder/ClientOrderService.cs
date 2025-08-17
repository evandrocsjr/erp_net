using erp_back_net.Data;
using erp_back_net.Entities.ClientOrder.Dtos;

namespace erp_back_net.Services.ClientOrder;

public class ClientOrderService(ErpDbContext dbContext) : IClientOrderService
{
    public Task<ClientOrderDto> CreateAsync(ClientOrderCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ClientOrderDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ClientOrderDto> UpdateAsync(long id, ClientOrderUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}