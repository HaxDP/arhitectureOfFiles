using System;

class Program
{
    static void Main(string[] args)
    {
        LibraryData libraryData = new LibraryData();
        LibraryUI ui = new LibraryUI(libraryData);

        while (true)
        {
            Console.WriteLine("\nLibrary System");
            Console.WriteLine("1. Display all books");
            Console.WriteLine("2. Add a book");
            Console.WriteLine("3. Remove a book");
            Console.WriteLine("4. Find a book");
            Console.WriteLine("5. Exit");
            
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ui.DisplayBooks();
                    break;
                case "2":
                    ui.AddBook();
                    break;
                case "3":
                    ui.RemoveBook();
                    break;
                case "4":
                    ui.FindBook();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}