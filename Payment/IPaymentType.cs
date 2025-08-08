namespace MyProgram
{
    public interface IPaymentType
    {
        public string Type { get; }

        public void ProcessPayment();
    }
}