using System;
class Order
{
    public List<Product> Products { get; }
    public Customer Customer { get; }
        public Order(Customer customer, List<Product> products)
    {
        Products = products;
        Customer = customer;
        
    }

    public decimal TotalCost()
    {
        decimal totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.TotalCost();
        }

        if (Customer.USA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35; 
        }

        return totalPrice;
    }

    public string ShippingLabel()
    {
        string shippingLabel = $"Customer Name: {Customer.Name}";
        shippingLabel += Customer.Address.GetAddress();
        return shippingLabel;
    }

    public string PackingLabel()
    {
        string packingLabel = string.Empty;
        foreach (Product product in Products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.ProductId}";
        }
        return packingLabel;
    }

    
}
