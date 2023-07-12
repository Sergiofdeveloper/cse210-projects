class OutdoorGatheringEvent : Event
{
    private string weatherForecast;

    public OutdoorGatheringEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetCompleteDetails()
    {
        return $"{base.GetCompleteDetails()}Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}\n";
    }
}
