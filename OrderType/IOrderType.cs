namespace MyProgram
{
    public enum OrderStatus { Confirmed, Ready, Done }
    public interface IOrderType
    {
        public string Type { get; }
        // public string GetConfirmedMessage();
        // public string GetReadyMessage();
        // public string GetDoneMessage();
        public string GetMessage(OrderStatus status);

    }
}