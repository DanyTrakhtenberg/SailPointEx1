using Models;
using System.Collections.Generic;

namespace BookParserInterface
{

    public interface IParser
    {
        List<Book> GetParseBooks(List<Book> bookList,List<IParsingRule> parsingRuls, List<IDeleteRule> deleteRules);
    }
}