using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OnePercent.Plans.Models
{
    public class Plan
    {
        public Guid Id { get; set; }

        public Guid CreatorId { get; set; }

        public IList<Step> Steps { get; } = new List<Step>();

        [JsonIgnore] public DateTimeOffset Created { get; set; }

        [JsonIgnore] public DateTimeOffset Updated { get; set; }
    }
}