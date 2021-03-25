using BookParserInterface;
using System.Collections.Generic;
using System.Linq;

namespace BookParserNameSpase
{
    public class ParsingManager
    {
        private readonly IParser parser;
        private readonly IFileReder fileReder;
        private readonly IFileSaver fileSaver;
        private readonly List<IParsingRule> parsingRulList;
        private readonly List<IDeleteRule> deleteRuleList;

        public ParsingManager(IParser parser, IFileReder fileReder, IFileSaver fileSaver, List<IParsingRule> parsingRulList, List<IDeleteRule> DeleteRuleList)
        {
            this.parser = parser;
            this.fileReder = fileReder;
            this.fileSaver = fileSaver;
            this.parsingRulList = parsingRulList;
            deleteRuleList = DeleteRuleList;
        }

        public void ParsedBookData(string jsonPath)
        {
            var booksList = this.fileReder.GetBooks(jsonPath);
            var parsedBookList = this.parser.GetParseBooks(booksList, this.parsingRulList, this.deleteRuleList).OrderBy(book => book.Author).ToList();
            this.fileSaver.Save(parsedBookList);
        }
    }
}
