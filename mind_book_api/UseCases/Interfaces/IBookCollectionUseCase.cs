using mind_book_api.DTOs;
using mind_book_api.Entities;

namespace mind_book_api.UseCases.Interfaces
{
    public interface IBookCollectionUseCase
    {
        public Task<BookCollection> Create(CreateBookCollectionDTO data);

        public Task<BookCollection> GetByOwnerId(Guid ownerId);

        public Task<BookCollection> AddBookInCollection(int idCollection, Book book);

        public Task<BookCollection> RemoveBookFromCollection(int idCollection, Book book);

        public void Delete(BookCollection data);

    }
}
