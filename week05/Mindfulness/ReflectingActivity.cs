public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();

        // add prompts and questions here
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}