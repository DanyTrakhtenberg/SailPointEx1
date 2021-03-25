using Models;
using System.Collections.Generic;

namespace BookParserInterface
{
    public interface IFileReder
    {
        List<Book> GetBooks(string path);
    }
}