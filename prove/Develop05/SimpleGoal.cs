public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value)
        : base(name, description, value)
    {
    }

    public override void MarkCompleted(ref int totalPoints)
    {
        if (!IsCompleted)
            {
                IsCompleted = true;
                totalPoints += Value;  
            }
    }
}
