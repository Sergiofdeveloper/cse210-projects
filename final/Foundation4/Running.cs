public class Running : Activity
{
    public double Distance { get; set; }

    public override double Distance()
    {
        return Distance;
    }

    public override double Speed()
    {
        return (Distance / LengthInMinutes) * 60;
    }

    public override double Pace()
    {
        return LengthInMinutes / Distance;
    }

    public override string Summary()
    {
        double distance = Distance();
        double speed = Speed();
        double pace = Pace();

        string summary = $"{Date:dd MMM yyyy} Running ({LengthInMinutes} min) - " +
                         $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";

        return summary;
    }
}
