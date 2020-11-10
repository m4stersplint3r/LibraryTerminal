using System;
using System.Collections.Generic;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            int menuChoice;
            bool notFinished = true;
            while (notFinished)
            {
                lib.DisplayMenu();
                // GetMenuChoice is stored as an int and passed into ExecuteMenuChoice which calls the appropriate method based on user choice
                menuChoice = lib.GetMenuChoice();
                lib.ExecuteMenuChoice(menuChoice);
                // save an changes made to text file (database)
                lib.UploadStockInformation();
                // prompt user to continue
                notFinished = lib.ReturnContinueChoice();
            }
        }
    }
}