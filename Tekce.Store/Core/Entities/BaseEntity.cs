﻿using System;

namespace Core.Entities
{
    public class BaseEntity : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid? CreatedBy { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual Guid? ChangedBy { get; set; }
        public virtual DateTime? Changed { get; set; }
    }
    public class BaseDto : IDto
    {
        public virtual Guid Id { get; set; }
        public virtual Guid? CreatedBy { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual int? ChangedBy { get; set; }
        public virtual DateTime? Changed { get; set; }
        public virtual string CreatedBy_Title { get; set; }
        public virtual string ChangedBy_Title { get; set; }

    }
}