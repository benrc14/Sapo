using System;
using System.Linq;

namespace Sapo.Models
{
    public class EFSapoRepository : ISapoRepository
    {
        private BookstoreContext context { get; set; }

        public EFSapoRepository(BookstoreContext temp)
        {
            context = temp;
        }


        public IQueryable<Book> Books => (IQueryable<Book>)context.Books;

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}


