class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;
    private int _totalCost;
        public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
        _totalCost = _price * _quantity;


    }

    public int GetTotalCost()
    {
        return _totalCost;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _productId;
    }
}