using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete
{
    public class User : BaseEntity
    {
        public User()
        {
            Status = true;
        }

        public long CitizenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RefreshToken { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Status { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Gender { get; set; }
        [NotMapped]
        public string AuthenticationProviderType { get; set; } = "Person";
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}