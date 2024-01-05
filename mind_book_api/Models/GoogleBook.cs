using System.Text.Json.Serialization;

namespace mind_book_api.Models
{
    public struct GoogleBook
    {
        [JsonPropertyName("totalItems")]
        public int? TotalItems { get; set; }

        [JsonPropertyName("items")]
        public IEnumerable<BookItem> Books { get; set; }
    }
}
