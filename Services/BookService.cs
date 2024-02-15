using Microsoft.EntityFrameworkCore;
using ZeissRestWebServiceDemo.Context;
using ZeissRestWebServiceDemo.Models;

namespace ZeissRestWebServiceDemo.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Book book)
        {
            await _context.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var book = await _context.Books.FirstAsync(b => b.BookId == id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Books.FirstAsync(b => b.BookId == id);
        }

        public async Task UpdateAsync(int id, Book book)
        {
            var bookDb = await _context.Books.FirstAsync(b => b.BookId == id);
            bookDb.Title = book.Title;
            bookDb.Pages = book.Pages;
            bookDb.Price = book.Price;
            bookDb.Author = book.Author;

            await _context.SaveChangesAsync();
        }
    }
}
