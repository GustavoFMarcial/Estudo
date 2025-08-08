using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace MyProgram
{
    public static class ClientValidator
    {
        public static void ValidateClient(string name, string phoneNumber, string email, string address)
        {
            if (String.IsNullOrEmpty(name) || name.Length <= 2) throw new ValidationException("Name must contain at least 2 caracters");
            if (String.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 9) throw new ValidationException("Phone number must have 9 digits");
            if (String.IsNullOrEmpty(email) || email.Length < 10 || !email.Contains("@gmail.com")) throw new ValidationException("Invalid email");
            if (string.IsNullOrEmpty(address) || address.Length < 25) throw new ValidationException("Invalid address");
        }
    }
}