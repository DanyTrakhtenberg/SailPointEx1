using BookParserInterface;
using Models;
using System;
using System.Collections.Generic;

namespace BookParserNameSpase
{
    public class BookParser : IParser
    {
        public List<Book> GetParseBooks(List<Book> bookList, List<IParsingRule> parsingRuls, List<IDeleteRule> deleteRules)
        {
            List<Book> returnedBookList = new List<Book>();
            bool isDeletedBook = false;
            foreach (var book in bookList)
            {
                isDeletedBook = false;
                foreach (var deleteRule in deleteRules)
                {
                    if (deleteRule.IsDeleteRule(book)==true)
                    {
                        isDeletedBook = true;
                        break;
                    }
                }
                if (isDeletedBook == true)
                {
                    continue;
                }
                foreach (var parseRule in parsingRuls)
                {
                    parseRule.SetBookByRule(book);
                }
                returnedBookList.Add(book);
            }
            return returnedBookList;
        }
    }
}
