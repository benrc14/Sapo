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
    }
}


