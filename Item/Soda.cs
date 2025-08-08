namespace MyProgram
{
    public class Soda : IItem
    {
        public string Name { get; private set; } = "Soda";
        public int Price { get; private set; } = 5;
    }
}