namespace MyProgram
{
    public interface IOrderType
    {
        public string Type { get; }
        public string GetReadyMessage();
        public string GetDoneMessage();
        
    }
}