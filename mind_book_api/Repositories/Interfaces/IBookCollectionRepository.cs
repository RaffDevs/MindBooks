using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.DTOs;
using mind_book_api.Entities;

namespace mind_book_api.Repositories.Interfaces
{
    public interface IBookCollectionRepository
    {
        public Task<BookCollection> Create(CreateBookCollectionDTO data);

        public Task<BookCollection> GetByOwnerId(Guid ownerId);

        public void AddBookInCollection(ref BookCollection collection, Book book);

        public void RemoveBookFromCollection(ref BookCollection collection, Book book);

        public void Delete(BookCollection data);

        public Task Commit();

    }

}