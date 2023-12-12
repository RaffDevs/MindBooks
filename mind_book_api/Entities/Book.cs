using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Entities
{
    [Table("books")]
    public class Book
    {
        [Key]
        public int Id { get; private set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Authors { get; set; }

        public string? Publisher { get; set; }

        public DateTime? PublishedDate { get; set; }

        public int? PageCount { get; set; }

        public string? Language { get; set; }

        public string? ThumbnailSmallLink { get; set; }

        public string? ThumbmailLink { get; set; }

        public string? BookId { get; set; }

        public string? ISBN { get; set; }
    }
}