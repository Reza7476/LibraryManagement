using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement;
public class Management : ILibrary
{


    private List<Category> categories = new();
    private List<Book> books = new();
    public void SetCategory(string name)
    {

        var checkCategory = categories.Find(_ => _.Name == name);
        if (checkCategory == null)
        {
            Category category = new(name);
            categories.Add(category);
            Success();
        }
        else
        {
            throw new Exception("this category exists");
        }

    }
    public void AddNewBook(string categoryName, string bookTitle,
        string authure)
    {
        var checkCategory = categories.Find(_ => _.Name == categoryName);
        if (checkCategory != null)
        {
            var book = books.Find(_ => _.Title == bookTitle);

            if (book == null)
            {
                Book newBook = new(bookTitle, authure, categoryName);
                books.Add(newBook);
                Success();
            }
        }
        else
        {
            throw new Exception("category not found");
        }
    }
    public Book GetBook(string bookName)
    {
        var checkBook = books.Find(_ => _.Title == bookName);

        if (checkBook != null)
        {
            return checkBook;
        }
        else
        {
            return null;
        }
    }
    public void EditBookName(string oldBookName, string newBookName)
    {
        var checkBook = books.Find(_ => _.Title == oldBookName);
        if (checkBook != null)
        {
            checkBook.Edit(newBookName, checkBook.Authure, checkBook.Category);
            Success();

        }
    }
    public void EditBookAuthure(string oldBookName, string newAuthure)
    {
        var checkBook = books.Find(_ => _.Title == oldBookName);
        if (checkBook != null)
        {
            checkBook.Edit(checkBook.Title, newAuthure, checkBook.Category);
            Success();

        }
    }
    public void DisplayBooks()
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        foreach (var book in books)
        {
            Console.WriteLine($" book name: {book.Title}  authure: {book.Authure} category: {book.Category} ");
        }
        Console.ResetColor();
    }
    public void RemoveBook(string bookName)
    {
        var book = books.Find(_ => _.Title == bookName);

        if (book != null)
        {
            books.Remove(book);
            Success();
        }
        else
        {
            throw new Exception("book not found");
        }
    }
    public void EditBookNameAndAuther(Book oldBook)
    {
        if (oldBook != null)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nbook name: {oldBook.Title}  authure: {oldBook.Authure}\n" +
                $"\t choice an option\n" +
                $"\t1:   edit bookname " +
                $"\t2:   edit auther");
            Console.ResetColor();
            var getOperator = int.Parse(Console.ReadLine()!);
            if (getOperator == 1)
            {
                var newBookName = GetString("enter new book name");
                EditBookName(oldBook.Title, newBookName);
            }
            else if (getOperator == 2)
            {
                var newAuthureName = GetString("enter new auther name");
                EditBookAuthure(oldBook.Title, newAuthureName);
            }
            else
            {
                Error("invalid number operation");
            }
        }
        else
        {
            throw new Exception("book not found");
        }
    }
    public void Displaydetails(string bookName)
    {
        var book = books.Where(_ => _.Title == bookName).ToList();
        if (book != null)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var Book in book)
            {
                Console.WriteLine($" {Book.Title}  authure:{Book.Authure}  category: {Book.Category}");
            }
            Console.ResetColor();
        }
    }






    public int Run()
    {
        Console.WriteLine($"1: Create category\n" +
            $"2: Add New book\n" +
            $"3: Display books\n" +
            $"4: Edit Book Name or authure\n" +
            $"5  Remove Book\n" +
            $"6: Display Book details");


        int value = int.Parse(Console.ReadLine());
        return value;
    }

    public string GetString(string message)
    {
        Console.WriteLine(message);
        var value = Console.ReadLine();
        return value;
    }

    public int GetInteger(string message)
    {
        Console.WriteLine(message);
        var value = int.Parse(Console.ReadLine());
        return value;
    }

    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public void Success()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"------------\nSuccess\n------------");
        Console.ResetColor();
    }



}
