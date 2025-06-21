public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        DisplayBreathingInstructions();
        DisplayEndingMessage();
        ShowCountDown(_duration);
        //DisplayBreathingInstructions();
        //DisplayEndingMessage();
    }

    public void DisplayBreathingInstructions()
    {
        Console.WriteLine("Take a deep breath in...");
        ShowSpinner(5);
        Console.WriteLine("Now breathe out...");
        ShowSpinner(5);
    }
}