using erp_back_net.Entities.User.Dtos;

namespace erp_back_net.Services.User;

public interface IUserService
{
    Task<UserDto> CreateAsync(UserCreateDto dto);
    
    Task<UserDto> GetByIdAsync(long id);
    
    Task<UserDto> UpdateAsync(long id, UserUpdateDto dto);

    Task DeleteAsync(long id);
}