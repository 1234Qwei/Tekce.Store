using System;

namespace Core.Entities.Concrete
{
    public class GroupClaim : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid ClaimId { get; set; }
    }
}