using System.Collections.Generic;
using System.IO; 
public class Journal
{
    public Journal()
    {
    }

    public List<Entry> entries = new List<Entry>();

    public void AddEntry()
        {
            Generate prompt = new Generate();
            string thisPrompt = prompt.GeneratePrompt();
            Console.WriteLine(thisPrompt);

            Entry entry = new Entry();

            DateTime theCurrentTime = DateTime.Now;
            entry._date = theCurrentTime.ToShortDateString();

            entry._prompt = thisPrompt;

            entry._userInput = Entry.Input();

            entry.Display();
            entries.Add(entry);

        }

    public void Display()
        {
            foreach (Entry entry in entries)
            {
                entry.Display();
            }
        }

    public List<Entry> Load()
        {
            Console.WriteLine("Please enter the filename of your journal file (eg. Journal.csv): ");
            string fileName = Console.ReadLine();
            entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];

                string editstring = parts[2];
                entry._userInput = editstring.Replace('|',',');

                entries.Add(entry);

            }

            Console.WriteLine($"{fileName} has been loaded.");
            return entries;

        }

    public void Save()
        {
            Console.WriteLine("Please enter the filename of your journal file (eg. Journal.csv): ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Saving to file... ");
            using (StreamWriter output = new StreamWriter(fileName))
                {   
                    foreach (Entry entry in entries)
                    {
                        string editstring = entry._userInput;
                        editstring = editstring.Replace(',','|');
                        output.WriteLine($"{entry._date},{entry._prompt},{editstring}");
                    }
                }
        }
}