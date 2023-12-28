using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRepository
{
    public class BookRepository
    {
        private BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public void AddBook(string title, string author)
        {
            Book book=new Book()
            {
                Title = title,
                Author = author
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public List<Book> FetchBooks()
        {
            return _context.Books.ToList();
        }
    }
}
