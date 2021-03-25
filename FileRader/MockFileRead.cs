using BookParserInterface;
using Models;
using System.Collections.Generic;

namespace FileReader
{
    public class MockFileRead : IFileReder
    {
        private readonly List<Book> books;

        public MockFileRead(List<Book> books)
        {
            this.books = books;
        }
        public List<Book> GetBooks(string path)
        {
            return books;
        }
    }
}
