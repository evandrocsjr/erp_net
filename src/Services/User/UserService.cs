using erp_back_net.Data;
using erp_back_net.Entities.User;
using erp_back_net.Entities.User.Dtos;
using Mapster;

namespace erp_back_net.Services.User;

public class UserService(ErpDbContext dbContext) : IUserService
{
    public async Task<UserDto> CreateAsync(UserCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> UpdateAsync(long id, UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}