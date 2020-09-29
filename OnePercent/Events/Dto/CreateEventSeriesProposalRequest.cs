using System.Collections.Generic;
using OnePercent.Events.Models;

namespace OnePercent.Events.Dto
{
    public class CreateEventSeriesProposalRequest
    {
        public IEnumerable<Want> Wants { get; set; }
    }
}