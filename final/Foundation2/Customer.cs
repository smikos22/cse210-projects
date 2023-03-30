class Customer
{
    private string _name;
    private Address _address;
    private bool _inUSA;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _inUSA = address.IsAddressInUSA();
    }
    public void SetIsInUSA(bool inUSA)
    {
        _inUSA = inUSA;
    } 
    public bool GetIsInUSA()
    {
        return _inUSA;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddressLocation()
    {
        return _address.GetFormatedAddress();
    }
}