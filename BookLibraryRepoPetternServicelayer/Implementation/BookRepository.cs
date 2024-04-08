using BookLibraryRepoPetternCore;
using BookLibraryRepoPetternServicelayer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryRepoPetternServicelayer.Implementation
{
    public class BookRepository(BookDbContext context) : IBookRepository
    {
        private readonly BookDbContext _context = context;

        public async Task<IEnumerable<Book>> GetAll()
        {
          var data = await _context.Books.ToListAsync();
            return data;
        }

        public async Task<Book> GetById(int id)
        {
            return await _context.Books.FindAsync(id);

        }

        public async Task Add(Book model)
        {
            await _context.AddAsync(model);
            _context.SaveChanges();
            //return Task.CompletedTask;
        }


        public async Task Update(Book model)
        {
           var data = await _context.Books.FindAsync(model.Id);

            if (data != null) 
            {
                data.Title = model.Title;
                data.Author = model.Author;
                data.Genre = model.Genre;
                data.Description = model.Description;   
                data.PublishDate = model.PublishDate;
                _context.Books.Update(data);

                await _context.SaveChangesAsync();
            }
            
        }

        public async Task DeleteById(int id)
        {
            var data =  await _context.Books.FindAsync(id);
            if (data != null)
            {
                _context.Books.Remove(data);
                await _context.SaveChangesAsync();
            }
        }

       
        Task IBookRepository.Delete(Book model)
        {
            throw new NotImplementedException();
        }
    }
}
