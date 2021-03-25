using BookParserInterface;
using Models;
using System;

namespace BookParserNameSpase
{
    public class PriceRule : IParsingRule
    {
        public void SetBookByRule(Book book)
        {

            if(double.TryParse(book.Price, out double price) == true)
            {
                price = Math.Ceiling(price);
            }
            book.Price = price.ToString();
        }
    }

}
