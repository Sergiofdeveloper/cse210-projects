using System;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    //prompts store arrays of reflexive sentences for the user
    private string[] prompts = 
    {
        "-----Think of a time when you stood up for someone else.-----",
        "-----Think of a time when you did something really difficult.------",
        "-----Think of a time when you helped someone in need.-----",
        "-----Think of a time when you did something truly selfless.-----"
    };
    //questions store arrays of questions for the user
    private string[] questions = 
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };

    // override allows to change the inherited behavior
    protected override string GetDescription() 
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //overrides start
    public override void Start() 
    {
         base.Start();

         Random random = new Random(); // instance for Random to generate the questions and reflexive sentences
         string prompt = prompts[random.Next(prompts.Length)];

         Console.WriteLine("Consider the following prompt:");
         Console.WriteLine();
         Console.WriteLine(prompt);
         Console.WriteLine();
         Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
         Console.WriteLine("When you have something in mind, press Enter to continue...");
         Console.WriteLine();
         Console.Write("You may begin in: ");
         Pause(5);

        // loops repets twice
        for (int i = 0; i < 2; i++) 
        {
             string question = questions[random.Next(questions.Length)];
             Console.WriteLine(question);
             Console.ReadLine();
             Console.WriteLine();
         }
        
        Finish();
     }
}
