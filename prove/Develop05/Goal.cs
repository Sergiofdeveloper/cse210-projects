public class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Value { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
        IsCompleted = false;
    }

    public virtual void MarkCompleted(ref int totalPoints)
    {
        IsCompleted = true;
        totalPoints += Value;
    }
}