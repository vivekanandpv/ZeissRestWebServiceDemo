using ZeissRestWebServiceDemo.Models;

namespace ZeissRestWebServiceDemo.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task CreateAsync(Book book);
        Task UpdateAsync(int id, Book book);
        Task DeleteByIdAsync(int id);
    }
}
