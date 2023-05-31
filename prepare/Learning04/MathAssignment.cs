public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string textbook, string problem) : base (name, topic)
    {
        _textbookSection = textbook;
        _problems = problem;
    }

    public string GetHomework()
    {
        return $"{GetSummary()}\n{_textbookSection} {_problems}";
    }
}