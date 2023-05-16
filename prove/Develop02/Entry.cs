
public class Entry
{
    public string _date;
    public string _prompt;
    public string _userInput;
    public Entry()
    {        
    }            

    
    public static string Input()
        {            
            Console.WriteLine("\nEnter your response: ");
            string _userInput = Console.ReadLine();
            return _userInput;
        }

    public void Display()
        {
            Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt}\n{_userInput}");
        }

}