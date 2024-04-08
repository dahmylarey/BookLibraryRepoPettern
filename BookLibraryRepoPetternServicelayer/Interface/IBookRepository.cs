using BookLibraryRepoPetternCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryRepoPetternServicelayer.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetById(int id);
        Task Add(Book model);
        Task Update(Book model);
        Task DeleteById(int id);
        Task Delete(Book model);
    }
}
