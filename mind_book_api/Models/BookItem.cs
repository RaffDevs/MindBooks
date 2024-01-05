using System.Text.Json.Serialization;

namespace mind_book_api.Models
{
    public struct BookItem
    {
        [JsonPropertyName("id")]
        public string? Id {  get; set; }

        [JsonPropertyName("selfLink")]
        public string? SelfLink { get; set; }

        [JsonPropertyName("volumeInfo")]
        public BookInfo? VolumeInfo { get; set; }
    }
}
