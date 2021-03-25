using BookParserInterface;
using Models;
using System.Collections.Generic;

namespace FileSaver
{
    public class MockFileSaver : IFileSaver
    {
        public List<Book> books;
        public void Save(List<Book> books)
        {
            this.books = books;
        }
    }

}
