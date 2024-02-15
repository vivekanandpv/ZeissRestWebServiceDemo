using ZeissRestWebServiceDemo.Models;

namespace ZeissRestWebServiceDemo.Services
{
    public class BookService : IBookService
    {
        public async Task CreateAsync(Book book)
        {
            await Console.Out.WriteLineAsync($"Book created: {book.Title}");
        }

        public async Task DeleteByIdAsync(int id)
        {
            await Console.Out.WriteLineAsync($"Book deleted: {id}");
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await Task.FromResult(
                    new List<Book>
                    {
                        new Book {BookId=45, Title="Learning C#", Pages = 800, Author="John Doe", Price = 855.25},
                        new Book {BookId=46, Title="Learning Java", Pages = 800, Author="John Doe", Price = 855.25},
                        new Book {BookId=47, Title="Learning F#", Pages = 800, Author="John Doe", Price = 855.25},

                    }
                );
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await Task.FromResult(new Book { BookId = 45, Title = "Learning C#", Pages = 800, Author = "John Doe", Price = 855.25 });
        }

        public async Task UpdateAsync(int id, Book book)
        {
            await Console.Out.WriteLineAsync($"Updating the book: {id} title: {book.Title}");
        }
    }
}
