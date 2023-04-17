using ECommBlazor1.Shared.DTO;

namespace ECommBlazor1.Server.Services.CartService
{
    public interface ICartService
    {
        Task <ServiceResponse<List<CartProductDTO>>> GetCartProducts(List<CartItem> cartItems);
        Task <ServiceResponse<List<CartProductDTO>>> StoreCartItems(List<CartItem> cartItems);
        Task<ServiceResponse<int>> GetCartItemsCount();
        Task<ServiceResponse<List<CartProductDTO>>> GetDbCartProducts();
        Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);
        Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);
        Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);

    }
}
