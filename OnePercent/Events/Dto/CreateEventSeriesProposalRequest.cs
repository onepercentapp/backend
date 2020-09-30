using System.Collections.Generic;
using OnePercent.Events.Models;

namespace OnePercent.Events.Dto
{
    public class CreateEventSeriesProposalRequest
    {
        public IReadOnlyCollection<Want> Wants { get; set; }
    }
}