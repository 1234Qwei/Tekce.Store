using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public LocationTypes Type { get; set; }
        public Guid? Pid { get; set; }

    }
}
