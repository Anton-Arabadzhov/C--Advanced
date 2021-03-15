namespace P02._Books_Before
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Book n = new Book();
            Library los = new Library();
            los.AddBook(n);
            los.TurnPage(n);
            los.TurnPage(n);
            los.TurnPage(n);
            los.TurnPage(n);
            los.TurnPage(n);
             los.ClosePage(n);
            foreach (var item in los.BooksLocations)
            {
                Console.WriteLine(item.Location);
            }
        }
    }
}
