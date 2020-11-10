using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Movie : Media
    {
        public string Genre { get; set; }

        public Movie(string Title, Status Status, DateTime DueDate, string Genre)
            : base(Title, Status, DueDate)
        {
            this.Genre = Genre;
        }
    }
}
