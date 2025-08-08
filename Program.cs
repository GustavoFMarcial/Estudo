namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client gustavo = new Client("Gustavo", "999999999", "gustavo@gmail.com", "R. dos Catapimbas, bairro Joba, 123 - Cuiabá/MT");
            List<IItem> items = [new Fries(), new Hamburger(), new Soda(), new Cookie()];
            IOrderType delivery = new Pickup();
            INotificationSystem message = new EmailSender();
            IPaymentType pix = new Credit();

            Order o1 = new Order(gustavo, items, delivery, message, pix);

            o1.AddItems(new Fries());
            o1.ProcessPayment();
            o1.SendNotificationOrderConfirmed();
            o1.SendNotificationOrderReady();
            o1.SendNotificationOrderDone();
        }
    }
}       