class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public Address(string street, string city, string state)
    {
        Street = street;
        City = city;
        State = state;
    }
}
