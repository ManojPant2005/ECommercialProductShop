using Blazored.LocalStorage;
using ECommercial.Models.Dtos;
using ECommercial.Web.Services.Contracts;

namespace ECommercial.Web.Services
{
    public class ManageProductsLocalStorageService : IManageProductLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IProductService productService;
        private const string key = "ProductCollection";
        public ManageProductsLocalStorageService(ILocalStorageService localStorageService,
                                                 IProductService productService) 
        {
            this.localStorageService = localStorageService;
            this.productService = productService;
        }

        public async Task<IEnumerable<ProductDto>> GetCollection()
        {
            return await this.localStorageService.GetItemAsync<IEnumerable<ProductDto>>(key)
                    ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await this.localStorageService.RemoveItemAsync(key);
        }

        private async Task<IEnumerable<ProductDto>> AddCollection()
        {
            var productCollection = await this.productService.GetItems();

            if (productCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, productCollection);
            }

            return productCollection;

        }

    }
}