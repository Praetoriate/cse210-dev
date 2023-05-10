using System;

class Program
{
    static void Main(string[] args)
    {        
        Generate prompt = new Generate();
        
        
        string thisPrompt = prompt.GeneratePrompt();
        Console.WriteLine(thisPrompt);
        
        Entry entry = new Entry();
        entry._prompt = thisPrompt;
        entry.Display();
    }
    
}