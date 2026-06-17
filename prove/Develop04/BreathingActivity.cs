public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}