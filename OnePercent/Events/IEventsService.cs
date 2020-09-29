using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Events.Models;

namespace OnePercent.Events
{
    public interface IEventsService
    {
        Task<IEnumerable<Event>> CreateEventProposal(IEnumerable<Want> wants);
    }
}