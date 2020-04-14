namespace ProblemScenarios.Mocking
{
    public class OrderService
    {
        private readonly IOrderStorage _storage;

        public OrderService(IOrderStorage storage)
        {
            _storage = storage;
        }

        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);

            // Some other work

            return orderId;
        }
    }

    public class Order
    {
    }

    public interface IOrderStorage
    {
        int Store(object obj);
    }
}