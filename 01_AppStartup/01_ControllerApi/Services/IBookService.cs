using _01_ControllerApi.Models;

namespace _01_ControllerApi.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
    }
}