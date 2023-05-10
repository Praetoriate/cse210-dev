public class Entry
{
    public Entry()
        {
        }
    public string _prompt;

    static DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();

    static string Input()
        {
            
            Console.WriteLine("Enter your response: ");
            string _userInput = Console.ReadLine();
            return _userInput;
        }
    
    public string _userInput = Input();

    public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
            Console.WriteLine($"{_userInput}");
        } 


}