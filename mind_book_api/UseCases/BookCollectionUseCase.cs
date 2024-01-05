using mind_book_api.DTOs;
using mind_book_api.Entities;
using mind_book_api.Repositories.Interfaces;
using mind_book_api.UseCases.Interfaces;

namespace mind_book_api.UseCases
{
    public class BookCollectionUseCase : IBookCollectionUseCase
    {

        private IBookCollectionRepository _repository { get; }

        public BookCollectionUseCase(IBookCollectionRepository repository)
        {
            _repository = repository;
        }
        public Task<BookCollection> AddBookInCollection(int idCollection, Book book)
        {
            throw new NotImplementedException();
        }

        public Task<BookCollection> Create(CreateBookCollectionDTO data)
        {
            throw new NotImplementedException();
        }

        public void Delete(BookCollection data)
        {
            throw new NotImplementedException();
        }

        public Task<BookCollection> GetByOwnerId(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public Task<BookCollection> RemoveBookFromCollection(int idCollection, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
