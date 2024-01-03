using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.Context;
using mind_book_api.DTOs;
using mind_book_api.Entities;
using mind_book_api.Repositories.Interfaces;

namespace mind_book_api.Repositories
{
    public class BookRepository : IBookRepository
    {

        private DatabaseContext _context { get; }

        public BookRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Book> Create(Book data)
        {
            var result = await _context.Book.AddAsync(data);

            return result.Entity;
        }

        public async Task Delete(Book book)
        {
            _context.Book.Remove(book);
        }

        public async Task<Book>? GetById(int id)
        {
            var result = await _context.Book.FindAsync(id);

            return result;
        }

        public async Task<Book> Update(Book book)
        {

            _context.Book.Update(book);

            return book;

        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}