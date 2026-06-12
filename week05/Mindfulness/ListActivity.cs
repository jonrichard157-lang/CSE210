public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
        _prompts = new List<string>();

        // add prompts here
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}