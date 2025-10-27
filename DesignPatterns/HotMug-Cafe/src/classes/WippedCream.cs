public class WippedCream : CondimentDecorator
{
  public WippedCream(Beverage beverage) : base(beverage)
  {
  }
  public override string GetDescription()
  {
    return _wrappedBeverage.GetDescription() + " avec crème fouettée";  
  }
  public override float Cost()
  {
    return _wrappedBeverage.Cost() + 1.10f; 
  }
}
