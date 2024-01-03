using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mind_book_api.Exceptions;
using mind_book_api.Models;

namespace mind_book_api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    [Route("error")]
    public class ErrorController : ControllerBase
    {
        public ErrorResponse Error()
        {

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context?.Error;
            ErrorResponse errorResponse;

            if (exception is NotFoundException)
            {
                Response.StatusCode = NotFoundException.StatusCode;

                errorResponse = new ErrorResponse
                {
                    StatusCode = NotFoundException.StatusCode,
                    Message = NotFoundException.ErrorMessage
                };

            }
            else
            {
                Response.StatusCode = UnknowException.StatusCode;


                errorResponse = new ErrorResponse
                {
                    StatusCode = UnknowException.StatusCode,
                    Message = UnknowException.ErrorMessage
                };
            }

            return errorResponse;

        }
    }
}