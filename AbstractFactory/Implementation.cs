namespace AbstractFactory;

public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();

    IShippingCostsService CreateShippingCostsService();
}

public class BrazilShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BrazilDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new BrazilShippingCostsService();
    }
}

public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FranceDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new FranceShippingCostsService();
    }
}

public interface IShippingCostsService
{
    decimal ShippingCosts {  get; }
}

public interface IDiscountService
{
    int DiscountPercentage { get; }
}

public class BrazilDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

public class BrazilShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}

public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 10;
}


public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private int _orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
        _orderCosts = 200;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs: " + $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}
