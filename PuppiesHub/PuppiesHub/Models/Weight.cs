using System.Text.Json.Serialization;

namespace PuppiesHub.Models
{
    public class Weight
    {
        [JsonPropertyName("imperial")]
        public string Imperial { get; set; }

        [JsonPropertyName("metric")]
        public string Metric { get; set; }
    }


}
