using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    // Properties
    public string Name { get; set; }
    private List<Book> Books { get; set; }

    // Constructor
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Method to add a book to the list
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    // Method to remove a book by isbn
    public bool RemoveBook(string isbn)
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
        }
        Console.WriteLine("Book not found.");
        return false;
    }

    // Method to display all books
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    // Method to get a book by isbm
    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}