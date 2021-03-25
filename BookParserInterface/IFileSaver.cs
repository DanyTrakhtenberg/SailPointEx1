using Models;
using System.Collections.Generic;

namespace BookParserInterface
{

    public interface IFileSaver
    {
        void Save(List<Book> books);
    }

}