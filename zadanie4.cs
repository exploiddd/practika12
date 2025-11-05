using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafa
{
    public class Book
    {
        private readonly string Isbn;
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Книга: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"ISBN: {Isbn}");
        }

        public string ISBN => Isbn;
    }
}

using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fafa
{s
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("978-5-17-139207-9", "Дежавю", "Олег Нечипоренко");
            book.PrintBookInfo();
            book.Title = "God System";
            book.Author = "Дмитрий Ицков";
            book.PrintBookInfo();
        }
    }
}