namespace MyProgram
{
    public class Debit : IPaymentType
    {
        public string Type { get; private set; } = "Debit";

        public void ProcessPayment()
        {
            Console.WriteLine("Processing debit card payment type");
        }
    }
}