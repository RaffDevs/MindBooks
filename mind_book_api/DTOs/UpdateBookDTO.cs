using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.DTOs
{
    public class UpdateBookDTO
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Authors { get; set; }

        public string? Publisher { get; set; }

        public DateTime? PublishedDate { get; set; }

        public int? PageCount { get; set; }

        public string? Language { get; set; }

        public string? ThumbnailSmallLink { get; set; }

        public string? ThumbmailLink { get; set; }

    }
}