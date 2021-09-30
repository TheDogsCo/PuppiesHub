using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PuppiesHub.Models
{
    public class Dog
    {
        [JsonPropertyName("breeds")]
        public List<Breed> Breeds { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }
    }


}
