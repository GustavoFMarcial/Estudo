namespace MyProgram
{
    public class Pickup : IOrderType
    {
        public string Type { get; private set; } = "Pickup";
        public string GetConfirmedMessage() => "Pickup order confirmed";
        public string GetReadyMessage() => "Order ready to pickup";
        public string GetDoneMessage() => "Order picked up";
    }
}