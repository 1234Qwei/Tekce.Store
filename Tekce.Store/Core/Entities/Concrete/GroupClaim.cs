using System;

namespace Core.Entities.Concrete
{
    public class GroupClaim : IEntity
    {
        public Guid GroupId { get; set; }
        public Guid ClaimId { get; set; }
    }
}