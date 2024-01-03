using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Entities
{
    [Table("Owner")]
    public class Owner
    {
        [Key]
        public Guid Id { get; set; }

        public string? Username { get; set; }

    }
}