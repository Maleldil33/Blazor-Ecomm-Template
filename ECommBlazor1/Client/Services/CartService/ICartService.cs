﻿using ECommBlazor1.Shared.Models;

namespace ECommBlazor1.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
    }
}
