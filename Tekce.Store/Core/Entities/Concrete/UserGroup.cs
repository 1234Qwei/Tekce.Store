using System;

namespace Core.Entities.Concrete
{
    public class UserGroup : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}