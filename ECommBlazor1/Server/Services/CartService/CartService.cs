﻿using ECommBlazor1.Shared.DTO;

namespace ECommBlazor1.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;
        public CartService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<CartProductDTO>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = new ServiceResponse<List<CartProductDTO>>()
            {
                Data = new List<CartProductDTO>()
            };

            foreach (var item in cartItems)
            {
                var product = await _context.Products
                    .Where(p => p.Id ==  item.ProductId)
                    .FirstOrDefaultAsync();

                if (product == null) {
                    continue;
                }

                var productVariant = await _context.ProductVariants
                    .Where(v => v.ProductId == item.ProductId
                        && v.ProductTypeId == item.ProductTypeId)
                    .Include(v => v.ProductType)
                    .FirstOrDefaultAsync();

                if (productVariant == null)
                {
                    continue;
                }

                var cartProducts = new CartProductDTO
                {
                    ProductId = product.Id,
                    Title = product.Title,
                    ImageURL = product.ImageUrl,
                    Price = productVariant.Price,
                    ProductType = productVariant.ProductType.Name,
                    ProductTypeId = productVariant.ProductTypeId
                };

                result.Data.Add(cartProducts);
            }
            return result;
        }
    }
}
