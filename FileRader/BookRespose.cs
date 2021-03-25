using Models;
using System.Collections.Generic;

namespace FileReader
{
   
       public class BookResponse
        {
            public Dictionary<string, List<Book>> catalog { get; set; }
        }
    
}
