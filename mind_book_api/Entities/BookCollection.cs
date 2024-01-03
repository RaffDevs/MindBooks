using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Entities
{

    [Table("BooksCollection")]
    public class BookCollection
    {
        public int Id { get; private set; }

        public string? Name { get; set; }

        public Owner? Owner { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

    }
}