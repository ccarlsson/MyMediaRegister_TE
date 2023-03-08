using System.IO;

namespace MyMediaRegister_TE.Models;

class Book : Media
{
    private string _author;
    private int _pages;

    public Book(string title, string author, int pages)
    {
        _author = author;
        _pages = pages;
        _title = title;
    }

    public override string ToString()
    {
        return $"{_title} ({_author}, {_pages} sidor)";
    }
}


