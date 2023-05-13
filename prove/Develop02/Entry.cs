
using System.Collections.Generic;
using System.IO; 
public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _userInput { get; set; }
    public Entry()
    {    
        static string Input()
        {            
            Console.WriteLine("Enter your response: ");
            string _userInput = Console.ReadLine();
            return _userInput;
        }
    
        _userInput = Input();
    }            

    


    public void Display()
        {
            Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt}\n{_userInput}");
        }

    public void WriteEntry()
    {   string fileName = "Journal.csv";
        using (StreamWriter output = new StreamWriter(fileName))
        {   output.WriteLine("Date,Prompt,Input");
            output.WriteLine($"{_date},{_prompt},{_userInput}");
        }
    }

}