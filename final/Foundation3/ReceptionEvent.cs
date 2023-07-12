class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetCompleteDetails()
    {
        return $"{base.GetCompleteDetails()}Type: Reception\nRSVP Email: {rsvpEmail}\n";
    }
}
