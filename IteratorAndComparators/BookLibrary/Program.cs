using System;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Winnie The Pooh", 1967, new string[] { "A. A. Cuelo"}),
                    new Book("Under the Yoke", 1990, new string[] { "Paulo Cuelo"} )
            };

            Library<Book> myLibrary = new Library<Book>(books);

            foreach (var item in myLibrary)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
