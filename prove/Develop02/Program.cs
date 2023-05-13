using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;
        Journal thisJournal = new Journal();

        while (cont == true)
        {
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string i = Console.ReadLine();
            int selection = int.Parse(i);

            //Console.WriteLine(selection); **For testing, WORKED

            if (selection == 1) //Write
                {
                    thisJournal.AddEntry();
                }

            if (selection == 2) //Display
                {
                    thisJournal.Display();
                }

            if (selection == 3) //Load
                {
                    thisJournal.Load();
                }

            if (selection == 4) //Save
                {
                    thisJournal.Save();
                }

            if (selection == 5) //Quit
                {
                    Console.WriteLine("\nSee you tomorrow!");
                    cont = false;
                }

        }
    } 
}