public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double Distance()
    {
        return Speed * LengthInMinutes / 60;
    }

    public override double Speed()
    {
        return Speed;
    }

    public override double Pace()
    {
        return 60 / Speed;
    }

    public override string Summary()
    {
        double distance = Distance();
        double speed = Speed();
        double pace = Pace();

        string summary = $"{Date:dd MMM yyyy} Cycling ({LengthInMinutes} min) - " +
                         $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";

        return summary;
    }
}
