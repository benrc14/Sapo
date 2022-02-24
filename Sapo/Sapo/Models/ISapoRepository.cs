using System;
using System.Linq;

namespace Sapo.Models
{
    public interface ISapoRepository
    {
        IQueryable<Book> Books { get; }
    }
}
