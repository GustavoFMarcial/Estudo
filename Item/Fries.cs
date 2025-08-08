namespace MyProgram
{
    public class Fries : IItem
    {
        public string Name { get; private set; } = "Fries";
        public int Price { get; private set; } = 5;
    }
}