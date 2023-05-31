class WritingAssignment : Assignment
{
    private string bookTitle;

    public WritingAssignment(string studentName, string topic, string bookTitle)
        : base(studentName, topic)
    {
        this.bookTitle = bookTitle;
    }

    public string GetWritingInformation()
    {
        return $"{bookTitle} by {GetStudentName()}";
    }
}