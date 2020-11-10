using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    abstract class Media
    {
        public string Title { get; set; }
        public Status Status { get; set; }
        public DateTime DueDate { get; set; }
        public Media(string Title, Status Status, DateTime DueDate)
        {
            this.Title = Title;
            this.Status = Status;
            this.DueDate = DueDate;
        }
    }
}
