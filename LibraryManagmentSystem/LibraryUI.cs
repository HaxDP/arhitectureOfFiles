using System;

public class LibraryUI
{
    private LibraryData libraryData;

    public LibraryUI(LibraryData libraryData)
    {
        this.libraryData = libraryData;
    }

    public void DisplayBooks()
    {
        var books = libraryData.GetBooks();
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }

    public void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter publication year: ");
        int year = int.Parse(Console.ReadLine());

        Book book = new Book(title, author, year);
        libraryData.AddBook(book);
        Console.WriteLine($"Book '{title}' added.");
    }

    public void RemoveBook()
    {
        Console.Write("Enter title of book to remove: ");
        string title = Console.ReadLine();
        libraryData.RemoveBook(title);
        Console.WriteLine($"Book '{title}' removed.");
    }

    public void FindBook()
    {
        Console.Write("Enter title of book to find: ");
        string title = Console.ReadLine();
        var book = libraryData.FindBook(title);
        if (book != null)
        {
            Console.WriteLine($"Found - Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}