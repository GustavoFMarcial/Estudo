namespace MyProgram
{
    public class Client
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        public Client(string name, string phoneNumber, string email, string address)
        {
            ClientValidator.ValidateClient(name, phoneNumber, email, address);

            Id = "C" + Guid.NewGuid().ToString("N").Substring(0, 4);
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }
    }
}