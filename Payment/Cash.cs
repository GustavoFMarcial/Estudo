namespace MyProgram
{
    public class Cash : IPaymentType
    {
        public string Type { get; private set; } = "Cash";

        public void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment type");
        }
    }
}