using BookParserInterface;
using Models;

namespace BookParserNameSpase
{
    public class AuthorNameDeleteRule : IDeleteRule
    {
        public bool IsDeleteRule(Book book)
        {
            if (book.Author?.Contains("Peter") == true)
            {
                return true;
            }
            return false;
        }
    }
}
