using BookParserInterface;
using BookParserNameSpase;
using FileReader;
using FileSaver;
using Models;
using System;
using System.Collections.Generic;

namespace BookParserConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var parsingManager = new ParsingManager(new BookParser(), new JsonFileReader(), new CsvFileSaver(new CsvExport<Book>(), "outputCsv.csv"), new List<IParsingRule>() { new PriceRule() }, new List<IDeleteRule>() {new SabathDeleteRule(),new AuthorNameDeleteRule() });
            parsingManager.ParsedBookData("books.json");
            Console.WriteLine("Hello World!");
        }
    }
}
