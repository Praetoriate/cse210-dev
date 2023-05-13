using System.Collections.Generic;
using System.IO; 
public class Journal
{
    public Journal()
    {
    }

    public void AddEntry()
    {
        Generate prompt = new Generate();
        string thisPrompt = prompt.GeneratePrompt();
        Console.WriteLine(thisPrompt);

        Entry entry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

        entry._prompt = thisPrompt;

        entry.Display();
        entry.WriteEntry();

    }
}