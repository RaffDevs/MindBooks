using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Entities
{
    [Table("book_notes")]
    public class BookNotes
    {
        public int Id { get; private set; }

        [Required]
        public string? Note { get; set; }

        [ForeignKey("BookId")]
        public int? BookId { get; set; }

        [ForeignKey("UserId")]
        public string? UserId { get; set; }


    }
}