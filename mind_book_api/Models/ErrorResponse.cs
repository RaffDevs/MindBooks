using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Models
{
    public class ErrorResponse
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }

        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public ErrorResponse()
        {
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now;
            StatusCode = 0;
            Message = "An error!";
        }

    }
}