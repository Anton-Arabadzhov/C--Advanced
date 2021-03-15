using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02._Books_Before
{
    public class Library
    {
        private List<BookLocation> booksLocations;

        public Library()
        {
            booksLocations = new List<BookLocation>();
        }

        public List<BookLocation> BooksLocations { get => booksLocations; set => booksLocations = value; }

        public void AddBook(Book book)
        {
            booksLocations.Add(new BookLocation() { Book = book, Location = 0 }) ;
        }

        public int TurnPage(Book book)
        {
          BookLocation  booklocation =  booksLocations.First(b => b.Book == book);
           return booklocation.TurnPage();
           
        }
        public int ClosePage(Book book)
        {
            BookLocation booklocation = booksLocations.First(b => b.Book == book);
            return booklocation.ClosePage();
        }

    }
}
