using System;

namespace OnePercent.Events.Models
{
    public struct FreeTimeInterval
    {
        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }
    }
}