namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client gustavo = new Client("Gustavo", "999999999", "gustavo@gmail.com", "R. dos Catapimbas, bairro Joba, 123 - Cuiabá/MT");
            List<IItem> items = [new Fries(), new Hamburger(), new Soda(), new Cookie()];
            IOrderType delivery = new Delivery();
            INotificationSystem message = new MessageSender();
            IPaymentType pix = new Pix();

            Order o1 = new Order(gustavo, items, delivery, message, pix);

            Console.WriteLine(o1.OrderType.Type);
            o1.PaymentType.ProcessPayment();
            o1.OrderType.ProcessOrderType(message);
        }
    }
}       