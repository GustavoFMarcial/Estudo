namespace MyProgram
{
    public class Juice : IItem
    {
        public string Name { get; private set; } = "Juice";
        public int Price { get; private set; } = 5;
    }
}