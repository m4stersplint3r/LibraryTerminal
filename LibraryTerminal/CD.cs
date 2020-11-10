using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class CD : Media
    {
        public string Artist { get; set; }
        public CD(string Title, Status Status, DateTime DueDate, string Artist)
            : base(Title, Status, DueDate)
        {
            this.Artist = Artist;
        }
    }
}
