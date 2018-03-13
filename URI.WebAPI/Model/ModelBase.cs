using System;

namespace URI.WebAPI.Model
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public bool Ative { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
