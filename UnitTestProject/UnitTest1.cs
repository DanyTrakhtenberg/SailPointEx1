using BookParserNameSpase;
using FileReader;
using FileSaver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSabathDeleteRule_DayOfSabath_delete()
        {
            var sabathRule = new SabathDeleteRule();
         bool isDelete =   sabathRule.IsDeleteRule(new Book() { Publish_date = "2021-03-13" });
            Assert.AreEqual(isDelete, true);
        }

        [TestMethod]
        public void TestSabathDeleteRule_DayOfSabath_noDelete()
        {
            var sabathRule = new SabathDeleteRule();
            bool isDelete = sabathRule.IsDeleteRule(new Book() { Publish_date = "2021-03-12" });
            Assert.AreEqual(isDelete, false);
        }

        [TestMethod]
        public void TestSParsingManager_BooksWithPeter_noBooks()
        {
            var bookList = new List<Book>() { new Book() { Author = "Kress, Peter" } };
            var mockFileSaver = new MockFileSaver();
            var parsingManager = new ParsingManager(new BookParser(),new MockFileRead(bookList), mockFileSaver, new List<BookParserInterface.IParsingRule>(),new List<BookParserInterface.IDeleteRule>() { new AuthorNameDeleteRule() });
            parsingManager.ParsedBookData("");
            Assert.AreEqual(mockFileSaver.books.Count, 0);
        }
        [TestMethod]
        public void TestSParsingManager_BookWithDecimalPrice_onePrsedPook()
        {
            var bookList = new List<Book>() { new Book() { Price="2.1" } };
            var mockFileSaver = new MockFileSaver();
            var parsingManager = new ParsingManager(new BookParser(), new MockFileRead(bookList), mockFileSaver, new List<BookParserInterface.IParsingRule>() { new PriceRule() }, new List<BookParserInterface.IDeleteRule>() {});
            parsingManager.ParsedBookData("");
            Assert.AreEqual(mockFileSaver.books.Count, 1);
            Assert.AreEqual(mockFileSaver.books[0].Price, "3");

        }
    }
}
