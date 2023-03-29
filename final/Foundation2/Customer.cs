class Customer
{
    private string _name;
    private string _address;
    public bool _inUSA;
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
        return _address;
    }
}