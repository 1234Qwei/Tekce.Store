using System;

namespace Core.Entities.Dtos
{
    public class UserDto : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid? CreatedBy { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual int? ChangedBy { get; set; }
        public virtual DateTime? Changed { get; set; }
        public virtual string CreatedBy_Title { get; set; }
        public virtual string ChangedBy_Title { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string RefreshToken { get; set; }
    }
}