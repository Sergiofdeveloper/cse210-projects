public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value)
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
