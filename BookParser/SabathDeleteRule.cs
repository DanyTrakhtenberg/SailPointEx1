using BookParserInterface;
using Models;
using System;
using System.Globalization;

namespace BookParserNameSpase
{
    public class SabathDeleteRule : IDeleteRule
    {
        public bool IsDeleteRule(Book book)
        {
            if (DateTime.TryParseExact(book.Publish_date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date) == true)
            {
                if (date.Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
