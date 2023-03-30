class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _orderTotal;
    private string _packingLabel;
    private string _shippingLabel;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        _orderTotal = 0;
        foreach (Product product in products)
        {
            _orderTotal += product.GetTotalCost();
        }
        int shippingCost;
        if (customer.GetIsInUSA())
        {
            _orderTotal += 4;
        }
        else
        {
            _orderTotal += 35;
        }
        _shippingLabel = _customer.GetName();
        _shippingLabel += ": ";
        _shippingLabel +=_customer.GetAddressLocation();

    }
    
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GetName() + " (ID: " + product.GetId() + ")\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return _shippingLabel;
    }
    public int GetOrderTotal()
    {
        return _orderTotal;
    }


}
