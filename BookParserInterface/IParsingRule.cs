using Models;

namespace BookParserInterface
{
    public interface IParsingRule
    {
        void SetBookByRule(Book book);
    }

    public interface IDeleteRule
    {
        bool IsDeleteRule(Book book);
    }
}