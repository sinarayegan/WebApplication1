using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IBookRepository
    {
        Task<List<BooksDetailDto>> GetAllBooks();
    }
}