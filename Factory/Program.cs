using Factory;

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BR"),
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine(
        $"Percentage {discountService.DiscountPercentage} " +
        $"comming from {discountService}");
}

Console.ReadKey();