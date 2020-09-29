using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Events.Models;

namespace OnePercent.Events
{
    public class EventsService : IEventsService
    {
        public async Task<IEnumerable<Event>> CreateEventProposal(IEnumerable<Want> wants)
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