using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string GetInfo()
    {
        return $"Название: {Title}, Автор: {Author}, Страниц: {Pages}";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("В библиотеке нет книг.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }
    }

    public void FindBook(string title)
    {
        Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (foundBook != null)
        {
            Console.WriteLine("Книга найдена: " + foundBook.GetInfo());
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Создание книг
        Book book1 = new Book("Питер Пен", " Джеймс Мэтью Барри", 224);
        Book book2 = new Book("Малыш и Карлсон, который живёт на крыше", "Астрид Линдгрен", 192);
        Book book3 = new Book("Чарли и шоколадная фабрика", "Роальд Даль", 208);

        // Создание библиотеки и добавление книг
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Вывод  книг
        Console.WriteLine("Книги в библиотеке:");
        library.ShowBooks();

        // Запрос книги для поиска
        Console.WriteLine("\nВведите название книги для поиска:");
        string titleToFind = Console.ReadLine();

        // Поиск книги по названию
        library.FindBook(titleToFind);
    }
}
