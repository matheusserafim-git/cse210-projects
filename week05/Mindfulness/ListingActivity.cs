public class ListingActivity : Activity
{
    protected List<string> _prompts;
    protected int _count;

    public ListingActivity(string name, string description, int duration, List<string> prompts)
    : base(name, description, duration)
    {
        _prompts = prompts;
        _count = 0;
    }

    public override void Run()
    {
        ShowSpinner(4);
        DisplayStartMessage();
        

        while (_count < _prompts.Count)
        {
            Console.WriteLine($"Prompt {_count + 1}: {_prompts[_count]}");
            _count++;
        }

        GetRandomPrompt();
        GetListFromUser();
        //ShowSpinner(4);
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"Random Prompt: {_prompts[index]}");
    }

    public void GetListFromUser()
    {
        Console.WriteLine("Please enter a list of prompts (type 'done' when finished):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            _prompts.Add(input);
        }
    }


}