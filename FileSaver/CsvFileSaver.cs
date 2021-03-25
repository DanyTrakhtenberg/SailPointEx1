using BookParserInterface;
using Models;
using System;
using System.Collections.Generic;

namespace FileSaver
{
    public class CsvFileSaver : IFileSaver
    {
        private readonly FileSaver.CsvExport<Book> csvExport;
        private readonly string path;

        public CsvFileSaver(CsvExport<Book> csvExport,string path)
        {
            this.csvExport = csvExport;
            this.path = path;
        }
        public void Save(List<Book> books)
        {
            this.csvExport.Objects = books;
            this.csvExport.ExportToFile(path);
        }
    }
}
