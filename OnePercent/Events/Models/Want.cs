using System;
using System.Collections.Generic;

namespace OnePercent.Events.Models
{
    public struct Want
    {
        public DateTimeOffset Date { get; set; }

        public IReadOnlyList<FreeTimeInterval> FreeTimeIntervals { get; set; }

        public IReadOnlyCollection<WantItem> WantItems { get; set; }
    }
}