using erp_back_net.Entities.Product.Dtos;
using erp_back_net.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace erp_back_net.Controllers;

[Route("v1/product")]
public class ProductController(IProductService productService) : DefaultController
{
    
    /// <summary>
    ///     Creates a new Product.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ProductDto>> Create([FromBody] ProductCreateDto dto)
    {
        var response = await productService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Retrieves a Product by ID.
    /// </summary>
    [HttpGet("{id:long}")]
    public async Task<ActionResult<ProductDto>> GetById(long id)
    {
        var response = await productService.GetByIdAsync(id);
        return Ok(response);
    }
    
    /// <summary>
    ///     Updates a Product by ID.
    /// </summary>
    [HttpPut("{id:long}")]
    public async Task<ActionResult<ProductDto>> Update([FromBody] ProductUpdateDto dto, long id)
    {
        var response = await productService.UpdateAsync(id, dto);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }
    
    /// <summary>
    ///     Delete a Product by ID.
    /// </summary>
    [HttpDelete("{id:long}")]
    public async Task<NoContentResult> Delete(long id)
    {
        await productService.DeleteAsync(id);
        return NoContent();
    }
}