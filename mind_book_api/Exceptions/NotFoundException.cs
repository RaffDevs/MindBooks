using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Exceptions
{
    public class NotFoundException : Exception
    {
        static public string ErrorMessage { get; private set; } = "Not found records for this ID";
        static public int StatusCode { get; private set; } = 404;


        public NotFoundException(string message) : base(message)
        {

        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}