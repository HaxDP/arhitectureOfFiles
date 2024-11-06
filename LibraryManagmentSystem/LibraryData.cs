using System.Collections.Generic;
using System.Linq;

public class LibraryData
{
    private List<Book> books;

    public LibraryData()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(string title)
    {
        books = books.Where(book => book.Title != title).ToList();
    }

    public Book FindBook(string title)
    {
        return books.FirstOrDefault(book => book.Title == title);
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}