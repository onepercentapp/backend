﻿using System;
using System.Text.Json.Serialization;

namespace OnePercent.Events.Models
{
    public class Event
    {
        public Guid Id { get; set; }

        public Guid CreatorId { get; set; }

        public string Summary { get; set; }

        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }

        public Guid StepId { get; set; }

        [JsonIgnore] public DateTimeOffset Created { get; set; }

        [JsonIgnore] public DateTimeOffset Updated { get; set; }
    }
}