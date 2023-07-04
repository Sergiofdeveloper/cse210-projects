using System;

class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool USA()
    {
        return Country == "USA";
    }

    public string GetAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}
