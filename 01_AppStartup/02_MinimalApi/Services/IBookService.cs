using _02_MinimalApi.Models;

namespace _02_MinimalApi.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
    }
}