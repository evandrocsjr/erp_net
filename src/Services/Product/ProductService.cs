using erp_back_net.Data;
using erp_back_net.Entities.Product.Dtos;

namespace erp_back_net.Services.Product;

public class ProductService(ErpDbContext dbContext) : IProductService
{
    public Task<ProductDto> CreateAsync(ProductCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> UpdateAsync(long id, ProductUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}