using ECommercial.Models.Dtos;

namespace ECommercial.Web.Services.Contracts
{
    public interface IManageProductLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
