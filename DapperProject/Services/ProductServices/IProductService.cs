using DapperProject.Dtos.ProductDtos;

namespace DapperProject.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryProcAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);

        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAsync(int id);

        Task<GetByIdProductDto> GetByIdProductAsync(int id);

        Task<int> GetProductCountAsync();
    }
}
