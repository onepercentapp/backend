using System.Collections.Generic;
using OnePercent.Events.Models;

namespace OnePercent.Events.Dto
{
    public class CreateEventSeriesProposalResponse
    {
        public IEnumerable<Event> Events { get; set; }
    }
}