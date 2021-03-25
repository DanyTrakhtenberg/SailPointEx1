using BookParserInterface;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public class JsonFileReader : IFileReder
    {
        public List<Book> GetBooks(string path)
        {
            List<Book> bookList = new List<Book>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                BookResponse respose = JsonConvert.DeserializeObject<BookResponse> (json);
                respose?.catalog.TryGetValue("book", out bookList);
               
            }
            return bookList;
        }
    }
}
