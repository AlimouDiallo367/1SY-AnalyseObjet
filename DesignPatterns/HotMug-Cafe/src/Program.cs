Beverage beverage = new Regular();
beverage = new StreamedMilk(beverage);
beverage = new Chocolate(beverage);

Console.WriteLine(beverage);

beverage = new Expresso();
beverage = new WippedCream(beverage);
beverage = new Chocolate(beverage);
beverage = new Chocolate(beverage);
beverage = new Chocolate(beverage);

Console.WriteLine(beverage);

beverage = new Decaf();
Console.WriteLine(beverage);
