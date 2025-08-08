namespace MyProgram
{
    public class Cookie : IItem
    {
        public string Name { get; private set; } = "Cookie";
        public int Price { get; private set; } = 5;
    }
}