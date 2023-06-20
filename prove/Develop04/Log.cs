public class Log
{
    private string _entry;
    private string _dateTime;

    public Log()
    {
    }

    public void AddToLog(string entry)
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToString();

        _entry = entry;

        string filePath = "logfile.txt";
        File.AppendAllText(filePath, $"\n{_dateTime}, {_entry}");
    }

    public void ViewLog()
    {
        Console.Clear();

        string filePath = "logfile.txt";
        string text = File.ReadAllText(filePath);

        Console.WriteLine("\nMeditation Activity Log:");
        Console.WriteLine(text);
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

    public void ClearLog()
    {
        Console.Clear();

        string filePath = "logfile.txt";
        File.WriteAllText(filePath, "");

        Console.WriteLine("\nMeditation Activity Log has been cleared.");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();

    }

}