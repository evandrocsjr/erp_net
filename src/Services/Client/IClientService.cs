using erp_back_net.Entities.Client.Dtos;

namespace erp_back_net.Services.Client;

public interface IClientService
{
    Task<ClientDto> CreateAsync(ClientCreateDto dto);
    
    Task<ClientDto> GetByIdAsync(long id);
    
    Task<ClientDto> UpdateAsync(long id, ClientUpdateDto dto);

    Task DeleteAsync(long id);
}