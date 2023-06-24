public class ChecklistGoal : Goal
{
    public int RepsCount { get; set; }
    public int BonusValue { get; set; }
    public int CompletionCount { get; set; } // Added CompletionCount property

    public ChecklistGoal(string name, string description, int value, int repsCount, int bonusValue)
        : base(name, description, value)
    {
        RepsCount = repsCount;
        BonusValue = bonusValue;
        CompletionCount = 0; // Initialize CompletionCount to 0
    }

    public void MarkCompleted()
    {
        CompletionCount++;
        if (CompletionCount >= RepsCount)
        {
            IsCompleted = true;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Reps Count: {RepsCount}, Bonus Value: {BonusValue}";
    }
}
