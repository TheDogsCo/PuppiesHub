using System.Text.Json.Serialization;

namespace PuppiesHub.Models
{
    public class Breed
    {
        [JsonPropertyName("bred_for")]
        public string BredFor { get; set; }

        [JsonPropertyName("breed_group")]
        public string BreedGroup { get; set; }

        [JsonPropertyName("height")]
        public Height Height { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("life_span")]
        public string LifeSpan { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("reference_image_id")]
        public string ReferenceImageId { get; set; }

        [JsonPropertyName("temperament")]
        public string Temperament { get; set; }

        [JsonPropertyName("weight")]
        public Weight Weight { get; set; }
    }


}
