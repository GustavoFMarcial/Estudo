namespace MyProgram
{
    public class Credit : IPaymentType
    {
        public string Type { get; private set; } = "Credit";

        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment type");
        }
    }
}