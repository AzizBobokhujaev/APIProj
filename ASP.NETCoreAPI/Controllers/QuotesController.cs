using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreAPI.Db;
using ASP.NETCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        DataContext _context { get; }
        public QuotesController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Create(Quote quote)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ErrorAddQuotes", "Ваш цитат не корректно!");
                return BadRequest(ModelState);
            }
            quote.InsertDate = DateTime.Now.Date;
            _context.Quotes.Add(quote);
            ;
            if (await _context.SaveChangesAsync() > 0)
                return Ok("Цитат успешно добавлен!");

            return BadRequest("Получилось ошибка при добовлении цитата!");
        }
        [HttpGet]
        public async Task<ActionResult<List<Quote>>> GetAll()
        {
            await AvtoDelete();
            return await _context.Quotes.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> GetById(int id)
        {
            await AvtoDelete();
            Quote quote = await _context.Quotes.FindAsync(id);
            if (quote == null)
                return NotFound("Цитаты по такой Id не сушествует!!!");
            return new ObjectResult(quote);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Quote quote)
        {
            Quote quot = await _context.Quotes.FindAsync(id);

            if (quot == null)
                return NotFound("Цитаты по такой Id не сушествует!!!");
            quot.Text = quote.Text ?? quot.Text;
            quot.Author = quote.Author ?? quot.Author;
            quot.InsertDate = DateTime.Now.Date;
            if (await _context.SaveChangesAsync() > 0)
                return Ok("Цитат успешно изменен!");

            return BadRequest("Получилось ошибка при изменении цитата!");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var quot = await _context.Quotes.FindAsync(id);

            if (quot == null)
                return NotFound("Цитаты по такой Id не сушествует!!!");
            _context.Quotes.Remove(quot);
            if (await _context.SaveChangesAsync() > 0)
                return Ok("Цитат успешно удален!");

            return BadRequest("Получилось ошибка при удалении цитата!");
        }
        [NonAction]
        private async Task AvtoDelete()
        {
            foreach (var quote in await _context.Quotes.ToListAsync<Quote>())
            {
                if (quote.InsertDate.Month != DateTime.Now.Month)
                {
                    _context.Quotes.Remove(quote);
                }
            }
        }
    }
}
