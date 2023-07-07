public class Logger
{
    //ATTRIBUTES
    private DateTime _dateTime;

    //CONSTRUCTORS
    
    //GETS & SETS
    public DateTime TimeStamp()
    {
        DateTime timestamp = DateTime.Now;
        return timestamp;
    }

    //METHODS
    public void WriteHistory()
    {
        //Write current data to history.csv
    }

    public void ReadHistory()
    {
        //Display history.csv in console
    }

}