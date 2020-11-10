using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Book : Media
    {
        public string Author { get; set; }
        public Book(string Title, Status Status, DateTime DueDate, String Author)
            :base(Title, Status, DueDate)

        {
            this.Author = Author;
        }
    }
}
