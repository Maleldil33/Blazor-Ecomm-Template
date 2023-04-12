using ECommBlazor1.Shared.DTO;

namespace ECommBlazor1.Server.Services.CartService
{
    public interface ICartService
    {
        Task <ServiceResponse<List<CartProductDTO>>> GetCartProducts(List<CartItem> cartProducts);
    }
}
