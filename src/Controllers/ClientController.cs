using erp_back_net.Entities.Client.Dtos;
using erp_back_net.Services.Client;
using Microsoft.AspNetCore.Mvc;

namespace erp_back_net.Controllers;

[Route("v1/client")]
public class ClientController(IClientService clientService) : DefaultController
{
    /// <summary>
    ///     Creates a new Client.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ClientDto>> Create([FromBody] ClientCreateDto dto)
    {
        var response = await clientService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Retrieves a Client by ID.
    /// </summary>
    [HttpGet("{id:long}")]
    public async Task<ActionResult<ClientDto>> GetById(long id)
    {
        var response = await clientService.GetByIdAsync(id);
        return Ok(response);
    }
    
    /// <summary>
    ///     Updates a Client by ID.
    /// </summary>
    [HttpPut("{id:long}")]
    public async Task<ActionResult<ClientDto>> Update([FromBody] ClientUpdateDto dto, long id)
    {
        var response = await clientService.UpdateAsync(id, dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Delete a Client by ID.
    /// </summary>
    [HttpDelete("{id:long}")]
    public async Task<NoContentResult> Delete(long id)
    {
        await clientService.DeleteAsync(id);
        return NoContent();
    }
}