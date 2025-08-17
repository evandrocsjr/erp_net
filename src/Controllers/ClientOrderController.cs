using erp_back_net.Entities.ClientOrder.Dtos;
using erp_back_net.Services.ClientOrder;
using Microsoft.AspNetCore.Mvc;

namespace erp_back_net.Controllers;

[Route("v1/clientOrder")]
public class ClientOrderController(IClientOrderService clientOrderService) : DefaultController
{
    /// <summary>
    ///     Creates a new Client Order.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ClientOrderDto>> Create([FromBody] ClientOrderCreateDto dto)
    {
        var response = await clientOrderService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Retrieves a Client Order by ID.
    /// </summary>
    [HttpGet("{id:long}")]
    public async Task<ActionResult<ClientOrderDto>> GetById(long id)
    {
        var response = await clientOrderService.GetByIdAsync(id);
        return Ok(response);
    }
    
    /// <summary>
    ///     Updates a Client Order by ID.
    /// </summary>
    [HttpPut("{id:long}")]
    public async Task<ActionResult<ClientOrderDto>> Update([FromBody] ClientOrderUpdateDto dto, long id)
    {
        var response = await clientOrderService.UpdateAsync(id, dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Delete a Client Order by ID.
    /// </summary>
    [HttpDelete("{id:long}")]
    public async Task<NoContentResult> Delete(long id)
    {
        await clientOrderService.DeleteAsync(id);
        return NoContent();
    }
}