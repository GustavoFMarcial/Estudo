namespace MyProgram
{
    public class Delivery : IOrderType
    {
        public string Type { get; private set; } = "Delivery";
        public string GetConfirmedMessage() => "Delivery order confirmed";
        public string GetReadyMessage() => "Order on the way";
        public string GetDoneMessage() => "Order delivered";

    }
}