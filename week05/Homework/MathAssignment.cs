public class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string textbookSection, string problems, string studentName, string topic)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
{
    return $"section {_textbookSection} problems {_problems}";
    }
}