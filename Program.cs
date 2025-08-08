namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client gustavo = new Client("Gustavo", "999999999", "gustavo@gmail.com", "R. dos Catapimbas, bairro Joba, 123 - Cuiabá/MT");
            List<IItem> items = [new Fries(), new Hamburger(), new Soda(), new Cookie()];
            IOrderType pickup = new Pickup();
            IPaymentType pix = new Pix();

            Order o1 = new Order(gustavo, items, pickup, pix);

            o1.AddItems(new Fries());
            o1.ProcessPayment();
            o1.AddObserver(new MessageSender());
            o1.ConfirmOrder();
            o1.OrderReady();
            o1.OrderDone();
        }
    }
}       