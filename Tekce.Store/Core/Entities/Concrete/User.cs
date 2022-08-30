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
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RefreshToken { get; set; }
        public string MobilePhones { get; set; }
        public bool Status { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        [NotMapped]
        public string AuthenticationProviderType { get; set; } = "Person";

        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public bool UpdateMobilePhone(string mobilePhone)
        {
            if (mobilePhone == MobilePhones)
            {
                return false;
            }

            MobilePhones = mobilePhone;
            return true;
        }
    }
}