using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Events.Models;

namespace OnePercent.Events
{
    public class EventsService : IEventsService
    {
        public async Task<IReadOnlyList<Event>> GetEventSeriesProposalAsync(IReadOnlyCollection<Want> wants)
        {
            var result = new List<Event>();

            result.Add(new Event
            {
                Id = Guid.NewGuid()
            });

            return result;
        }
    }
}