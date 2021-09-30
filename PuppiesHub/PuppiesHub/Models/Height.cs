using System.Text.Json.Serialization;

namespace PuppiesHub.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Height
    {
        [JsonPropertyName("imperial")]
        public string Imperial { get; set; }

        [JsonPropertyName("metric")]
        public string Metric { get; set; }
    }


}
