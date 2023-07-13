using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string Summary();
}
