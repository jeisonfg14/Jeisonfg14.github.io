using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Models
{
    public class UserRegister
    {
        [Key]
        public string DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
