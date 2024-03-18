using ECommercial.Api.Data;
using ECommercial.Api.Entities;
using ECommercial.Api.Repositories.Contracts;
using ECommercial.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ECommerceDbContext eCommerceDbContext;

        public ShoppingCartRepository(ECommerceDbContext eCommerceDbContext)
        {
            this.eCommerceDbContext = eCommerceDbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.eCommerceDbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                     c.ProductId == productId);

        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this.eCommerceDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.eCommerceDbContext.CartItems.AddAsync(item);
                    await this.eCommerceDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;

        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.eCommerceDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                this.eCommerceDbContext.CartItems.Remove(item);
                await this.eCommerceDbContext.SaveChangesAsync();
            }

            return item;

        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.eCommerceDbContext.Carts
                          join cartItem in this.eCommerceDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.eCommerceDbContext.Carts
                          join cartItem in this.eCommerceDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.eCommerceDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.eCommerceDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}
