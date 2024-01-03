using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mind_book_api.Exceptions
{
    public class UnknowException : Exception
    {
        static public string ErrorMessage { get; private set; } = "Unexpected error!";
        static public int StatusCode { get; private set; } = 500;


        public UnknowException(string message) : base(message)
        {

        }

        public UnknowException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}