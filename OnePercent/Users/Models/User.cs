using System;
using System.Text.Json.Serialization;

namespace OnePercent.Users.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [JsonIgnore] public DateTimeOffset Created { get; set; }

        [JsonIgnore] public DateTimeOffset Updated { get; set; }
    }
}