using System.Text.Json.Serialization;

namespace mind_book_api.Models
{
    public struct BookInfo
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("authors")]
        public IEnumerable<string>? Authors { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("pageCount")]
        public int? PageCount { get; set; }

        [JsonPropertyName("categories")]
        public IEnumerable<string>? Categories { get; set; }

        [JsonPropertyName("imageLinks")]
        public BookCoverLinks? ImageLinks {get;set;}

        [JsonPropertyName("language")]
        public string? Language { get; set; }
    }
}
