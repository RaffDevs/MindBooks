using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.DTOs;
using mind_book_api.Entities;

namespace mind_book_api.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public Task<Book>? GetById(int id);

        public Task<Book> Create(Book data);

        public Task<Book> Update(Book data);

        public void Delete(Book data);

        public Task Commit();
    }
}