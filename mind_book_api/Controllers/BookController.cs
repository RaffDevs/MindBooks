using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mind_book_api.DTOs;
using mind_book_api.UseCases.Interfaces;

namespace mind_book_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookUseCase _useCase;

        public BookController(IBookUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _useCase.GetById(id);

            return Ok(book);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _useCase.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, UpdateBookDTO data)
        {
            var result = await _useCase.Update(id, data);
            return Ok(result);
        }
    }
}