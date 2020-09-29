using System;
using System.Collections.Generic;
using System.Linq;

namespace OnePercent.Events.Models
{
    public class Event
    {
        public Guid Id { get; set; }

        public Guid CreatorId { get; set; }

        public string Summary { get; set; }

        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }

        public Guid RecurringEventId { get; set; }

        public Guid PlanId { get; set; }

        public IEnumerable<Guid> Attendees { get; } = Enumerable.Empty<Guid>();

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}