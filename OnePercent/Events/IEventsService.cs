using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Events.Models;

namespace OnePercent.Events
{
    public interface IEventsService
    {
        Task<IReadOnlyList<Event>> GetEventSeriesProposalAsync(IReadOnlyCollection<Want> wants);
    }
}