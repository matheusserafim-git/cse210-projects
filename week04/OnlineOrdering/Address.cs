public class Address
{
    public string Street { get; }
    public string City { get; }
    public string StateOrProvince { get; }
    public string Country { get; }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}