namespace MyProgram
{
    public class Hamburger : IItem
    {
        public string Name { get; private set; } = "Hamburger";
        public int Price { get; private set; } = 10;
    }
}