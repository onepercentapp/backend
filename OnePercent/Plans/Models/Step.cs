using System;
using System.Text.Json.Serialization;

namespace OnePercent.Plans.Models
{
    public class Step
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        [JsonIgnore] public DateTimeOffset Created { get; set; }

        [JsonIgnore] public DateTimeOffset Updated { get; set; }
    }
}