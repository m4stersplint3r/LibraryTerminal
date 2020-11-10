using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Magazine : Media
    {
        public string Issue { get; set; }
        public Magazine(string Title, Status Status, DateTime DueDate, string Issue)
            : base(Title, Status, DueDate)
        {
            this.Issue = Issue;
        }
    }
}
