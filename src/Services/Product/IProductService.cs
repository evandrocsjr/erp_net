using erp_back_net.Entities.Product.Dtos;

namespace erp_back_net.Services.Product;

public interface IProductService
{
    Task<ProductDto> CreateAsync(ProductCreateDto dto);
    
    Task<ProductDto> GetByIdAsync(long id);
    
    Task<ProductDto> UpdateAsync(long id, ProductUpdateDto dto);

    Task DeleteAsync(long id);
}