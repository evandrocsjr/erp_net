using erp_back_net.Entities.User.Dtos;
using erp_back_net.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace erp_back_net.Controllers;

[Route("v1/user")]
public class UserController(IUserService userService) : DefaultController
{
    /// <summary>
    ///     Creates a new User.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<UserDto>> Create([FromBody] UserCreateDto dto)
    {
        var response = await userService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Retrieves a User by ID.
    /// </summary>
    [HttpGet("{id:long}")]
    public async Task<ActionResult<UserDto>> GetById(long id)
    {
        var response = await userService.GetByIdAsync(id);
        return Ok(response);
    }
    
    /// <summary>
    ///     Updates a User by ID.
    /// </summary>
    [HttpPut("{id:long}")]
    public async Task<ActionResult<UserDto>> Update([FromBody] UserUpdateDto dto, long id)
    {
        var response = await userService.UpdateAsync(id, dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Delete a User by ID.
    /// </summary>
    [HttpDelete("{id:long}")]
    public async Task<NoContentResult> Delete(long id)
    {
        await userService.DeleteAsync(id);
        return NoContent();
    }
}