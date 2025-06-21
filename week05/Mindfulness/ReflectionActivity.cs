public class ReflectionActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
    private int _count;

    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public override void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        ShowCountDown(_duration);

        while (_count < _prompts.Count)
        {
            Console.WriteLine($"Prompt {_count + 1}: {_prompts[_count]}");
            _count++;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on this prompt: {prompt}");
        ShowSpinner(5); // Simulate time for reflection
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Consider this question: {question}");
        ShowSpinner(5); // Simulate time for reflection
    }
}