using erp_back_net.Data;
using erp_back_net.Entities.User;
using erp_back_net.Entities.User.Dtos;
using Mapster;

namespace erp_back_net.Services;

public class UserService(ErpDbContext dbContext)
{
    public async Task CreateAsync(UserCreateDto dto)
    {
        var newUser = dto.Adapt<UserEntity>();
        
        await dbContext.Users.AddAsync(newUser);
        await dbContext.SaveChangesAsync();
    }
}