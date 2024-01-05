
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.Entities;

namespace mind_book_api.DTOs
{
    public class CreateBookCollectionDTO
    {
        public string? Name { get; set; }

        public Owner? Owner { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}