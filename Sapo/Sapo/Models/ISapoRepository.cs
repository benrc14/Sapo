using System;
using System.Linq;

namespace Sapo.Models
{
    public interface ISapoRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
    }
}
