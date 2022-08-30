using System;

namespace Core.Entities.Concrete
{
    public class UserClaim : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }
    }
}