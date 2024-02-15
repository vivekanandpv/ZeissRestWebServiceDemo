using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZeissRestWebServiceDemo.Models;
using ZeissRestWebServiceDemo.Services;

namespace ZeissRestWebServiceDemo.Apis
{
    [Route("api/v1/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            await _service.CreateAsync(book);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePut(int id, Book book)
        {
            await _service.UpdateAsync(id, book);
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdatePatch(int id, Book book)
        {
            await _service.UpdateAsync(id, book);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await _service.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
