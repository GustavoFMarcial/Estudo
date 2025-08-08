namespace MyProgram
{
    public class Pix : IPaymentType
    {
        public string Type { get; private set; } = "Pix";

        public void ProcessPayment()
        {
            Console.WriteLine("Processing pix payment type");
        }
    }
}