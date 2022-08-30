using System;

namespace Core.Entities.Concrete
{
    public class Translate : BaseEntity
    {
        public Guid LangId { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}