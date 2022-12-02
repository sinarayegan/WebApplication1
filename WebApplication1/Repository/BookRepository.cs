using System.Collections.Generic;
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

        // public async Task<List<BooksDetail>> GetAllBooks()
        // {
        //     var Books = _context
        //     return
        // }
    }
}
