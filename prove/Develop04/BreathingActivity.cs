using System;

class BreathingActivity : MindfulnessActivity
{

    // override allows to change the inherited behavior
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing...";
    }

    public override void Start()
    {
        // calls the method from base class and starts activity
        base.Start();
        // user´s choice divided by 4
        int breathDuration = duration / 4; 
        // loop goes twice
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Breathe in...");
            Pause(breathDuration);

            Console.Write("Now breathe out...");
            Pause(breathDuration);
        }

        Finish();
    }
}
