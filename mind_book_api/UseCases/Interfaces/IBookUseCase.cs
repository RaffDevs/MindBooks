using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.DTOs;
using mind_book_api.Entities;

namespace mind_book_api.UseCases.Interfaces
{
    public interface IBookUseCase
    {
        public Task<Book>? GetById(int id);

        public Task<Book> Create(CreateBookDTO data);

        public Task<Book> Update(int id, UpdateBookDTO data);

        public Task Delete(int id);
    }
}