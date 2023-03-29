class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;
    private int _totalCost;
    public void GetTotalCost()
    {
        _totalCost = _price * _quantity;
    }
}