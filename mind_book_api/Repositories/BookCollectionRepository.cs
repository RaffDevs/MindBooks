using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mind_book_api.Context;
using mind_book_api.DTOs;
using mind_book_api.Entities;
using mind_book_api.Exceptions;
using mind_book_api.Repositories.Interfaces;

namespace mind_book_api.Repositories
{
    public class BookCollectionRepository : IBookCollectionRepository
    {
        private DatabaseContext _context { get; }

        public BookCollectionRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void AddBookInCollection(ref BookCollection collection, Book book)
        {
            collection.Books.Add(book);
        }

        public async Task<BookCollection> Create(CreateBookCollectionDTO data)
        {
            var collection = new BookCollection
            {
                Name = data.Name,
                Owner = data.Owner,
                Books = data.Books
            };

            var result = await _context.BookCollection.AddAsync(collection);

            return result.Entity;
        }

        public void Delete(BookCollection data)
        {
            _context.BookCollection.Remove(data);
        }

        public async Task<BookCollection> GetByOwnerId(Guid ownerId)
        {
            var collection = await _context.BookCollection.FirstAsync(c => c.Owner.Id == ownerId);
            return collection;
        }

        public void RemoveBookFromCollection(ref BookCollection collection, Book book)
        {
            collection.Books.Remove(book);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}