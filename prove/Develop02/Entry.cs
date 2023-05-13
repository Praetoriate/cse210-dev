
public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _userInput { get; set; }
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
            Console.WriteLine($"\nYour latest entry:\nDate: {_date} - Prompt: {_prompt}\n{_userInput}");
        }

}