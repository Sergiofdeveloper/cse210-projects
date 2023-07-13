public class Swimming : Activity
{
    public int Laps { get; set; }

    // miles convertion
    public override double Distance()
    {
        return Laps * 50 / 1000 * 0.62;  
    }

    public override double Speed()
    {
        return (Distance() / LengthInMinutes) * 60;
    }

    public override double Pace()
    {
        return LengthInMinutes / Distance();
    }

    public override string Summary()
    {
        double distance = Distance();
        double speed = Speed();
        double pace = Pace();

        string summary = $"{Date:dd MMM yyyy} Swimming ({LengthInMinutes} min) - " +
                         $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";

        return summary;
    }
}
