using erp_back_net.Data;
using erp_back_net.Entities.Client;
using erp_back_net.Entities.Client.Dtos;
using Mapster;

namespace erp_back_net.Services.Client;

public class ClientService(ErpDbContext dbContext) : IClientService
{
    public async Task<ClientDto> CreateAsync(ClientCreateDto dto)
    {
        var newClient = dto.Adapt<ClientEntity>();
        newClient.CreatedAt = DateTime.Now.Ticks;
        newClient.UpdatedAt = DateTime.Now.Ticks;
        await dbContext.Clients.AddAsync(newClient);
        await dbContext.SaveChangesAsync();

        return newClient.Adapt<ClientDto>();
    }

    public Task<ClientDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ClientDto> UpdateAsync(long id, ClientUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}