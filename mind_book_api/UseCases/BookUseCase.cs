using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mind_book_api.DTOs;
using mind_book_api.Entities;
using mind_book_api.Exceptions;
using mind_book_api.Repositories.Interfaces;
using mind_book_api.UseCases.Interfaces;

namespace mind_book_api.UseCases
{
    public class BookUseCase : IBookUseCase
    {

        private IBookRepository _repository { get; }

        public BookUseCase(IBookRepository repository)
        {
            _repository = repository;

        }

        async public Task<Book> Create(CreateBookDTO data)
        {

            Book book = new Book
            {
                Authors = data.Authors,
                Description = data.Description,
                Language = data.Language,
                PageCount = data.PageCount,
                PublishedDate = data.PublishedDate,
                ThumbnailSmallLink = data.ThumbnailSmallLink,
                ThumbmailLink = data.ThumbmailLink,
                Title = data.Title,
                ISBN = data.ISBN,
                BookId = data.BookId,
                Publisher = data.Publisher
            };

            var result = await _repository.Create(book);

            if (result == null)
            {
                throw new UnknowException(UnknowException.ErrorMessage);
            }

            await _repository.Commit();
            return result;

        }

        async public Task Delete(int id)
        {
            var book = await _repository.GetById(id);

            if (book == null)
            {
                throw new NotFoundException(NotFoundException.ErrorMessage);
            }

            await _repository.Delete(book);

            await _repository.Commit();

        }

        public async Task<Book>? GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                throw new NotFoundException(NotFoundException.ErrorMessage);
            }

            return result;

        }

        public async Task<Book> Update(int id, UpdateBookDTO data)
        {
            var book = await _repository.GetById(id);

            if (book != null)
            {
                book.Title = data.Title;
                book.Description = data.Description;
                book.Authors = data.Authors;
                book.ThumbmailLink = data.ThumbmailLink;
                book.ThumbnailSmallLink = data.ThumbnailSmallLink;
                book.Publisher = data.Publisher;
                book.PublishedDate = data.PublishedDate;
                book.Language = data.Language;
                book.PageCount = data.PageCount;

                await _repository.Update(book);
                await _repository.Commit();
            }

            throw new NotFoundException(NotFoundException.ErrorMessage);

        }
    }
}