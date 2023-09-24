using AbstractFactory;

var brazilShoppingCartPurchaseFactory = new BrazilShoppingCartPurchaseFactory();
var shoppingCartFromBrazil = new ShoppingCart(brazilShoppingCartPurchaseFactory);
shoppingCartFromBrazil.CalculateCosts();

var franceShoppingCartPurchaseFactory = new  FranceShoppingCartPurchaseFactory();
var shoppingCartFromFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartFromFrance.CalculateCosts();
