class Customer
{
    private string _name;
    private Address _address;   // an object inside an object

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();   // asks the Address, as the hint says
    }
}