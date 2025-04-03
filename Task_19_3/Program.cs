namespace Task_19_3
{
    // Перечисление для статусов заказа
    public enum OrderStatus
    {
        New,        // Новый
        Processing, // В обработке
        Shipped,    // Отправлен
        Delivered,  // Доставлен
        Cancelled   // Отменён
    }

    // Класс для заказа
    public class Order
    {
        public int OrderId { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Status = OrderStatus.New; // Изначально статус нового заказа
        }

        // Метод для изменения статуса заказа
        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine($"Невозможно изменить статус заказа {OrderId}. Заказ уже {Status}.");
                return;
            }

            Status = newStatus;
            Console.WriteLine($"Заказ {OrderId} переведён в статус: {Status}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            Order order1 = new Order(1);

            order1.ChangeStatus(OrderStatus.Processing); // Заказ 1 переведён в статус: Processing.
            order1.ChangeStatus(OrderStatus.Shipped);    // Заказ 1 переведён в статус: Shipped.
            order1.ChangeStatus(OrderStatus.Delivered);   // Заказ 1 переведён в статус: Delivered.
            order1.ChangeStatus(OrderStatus.Cancelled);    // Невозможно изменить статус заказа 1. Заказ уже Delivered.
        }
    }
}
