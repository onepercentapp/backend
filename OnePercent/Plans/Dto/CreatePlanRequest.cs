using System;
using System.Collections.Generic;

namespace OnePercent.Plans.Dto
{
    public struct CreatePlanRequest
    {
        public Guid CreatorId { get; set; }

        public IReadOnlyList<StepDto> Steps { get; set; }
    }
}