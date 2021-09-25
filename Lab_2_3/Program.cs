using System;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title1 = new Title() { name = "The Old Man and the Sea" };
            Author author1 = new Author() { name = "Ernest Hemingway" };
            Content content1 = new Content() { content = "Lorem ipsum..." };

            Book book = new Book() { title = title1, author = author1, content = content1 };
            book.title.Show();
            book.author.Show();
            book.content.Show();
        }
    }

    public class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

    }
    public class Title
    {
        public string name;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"Название книги: {name}. ");
            Console.ResetColor();
        }
    }
    public class Author
    {
        public string name;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Автор книги: {name}. ");
            Console.ResetColor();
        }
    }
    public class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"Контент книги: {content}. ");
            Console.ResetColor();
        }
    }
}
