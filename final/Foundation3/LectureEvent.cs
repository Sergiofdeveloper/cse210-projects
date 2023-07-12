class LectureEvent : Event
{
    private string speaker;
    private int capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetCompleteDetails()
    {
        return $"{base.GetCompleteDetails()}Type: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}\n";
    }
}
