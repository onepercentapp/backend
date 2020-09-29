using System;
using System.Collections.Generic;

namespace OnePercent.Events.Models
{
    public struct Want
    {
        public DateTimeOffset Date { get; set; }

        public IEnumerable<FreeTimeInterval> FreeTimeIntervals { get; set; }

        public IEnumerable<WantItem> WantItems { get; set; }
    }
}