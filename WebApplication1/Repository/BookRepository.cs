using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<List<BooksDetailDto>> GetAllBooks()
        {
            var books =
                await _context
                    .Books
                    .Select(x =>
                        new BooksDetailDto()
                        {
                            Id = x.Id,
                            Title = x.Title,
                            Description = x.Description
                        })
                    .ToListAsync();
            return books;
        }

        public async Task<BooksDetailDto> GetBookDetailById(int id)
        {
            var book =
                await _context
                    .Books
                    .Where(x => x.Id == id)
                    .Select(x =>
                        new BooksDetailDto()
                        {
                            Id = x.Id,
                            Title = x.Title,
                            Description = x.Description
                        })
                    .SingleOrDefaultAsync();
            return book;
        }

        public async Task<int> CreateBook(CreateBookDto model)
        {
            var book =
                new Book()
                {
                    Title = model.Title,
                    Description = model.Description
                };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }
    }
}
