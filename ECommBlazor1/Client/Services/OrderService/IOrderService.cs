namespace ECommBlazor1.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlaceOrder();
        Task<List<OrderOverviewDTO>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
