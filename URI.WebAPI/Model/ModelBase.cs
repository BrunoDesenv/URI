using System;

namespace URI.WebAPI.Model
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public bool Ative { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
