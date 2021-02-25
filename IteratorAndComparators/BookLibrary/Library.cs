using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
     public class Library<T> : IEnumerable<Book> where T: Book
    {

        private readonly List<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }
        public Library(IEnumerable<Book> books)
        {
            this.books = new List<Book>(books);
        }
        //public IEnumerator<Book> GetEnumerator()
        //{
        //    // return new LibraryIterator(books);

        //    foreach (var book in books)
        //    {
        //        yield return book;
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}
    }
}
