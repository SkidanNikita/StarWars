using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StarWars
{
    public class Person
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("mass")]
        public int Mass { get; set; }
        [JsonPropertyName("hair_color")]
        public string Hair { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        public virtual Person IsPerson { get; set; }
    }
}
