public class Chocolate : CondimentDecorator
{
  public Chocolate(Beverage beverage) : base(beverage)
  {
  }
  public override string GetDescription()
  {
    return _wrappedBeverage.GetDescription() + " avec chocolat";  
  }
  public override float Cost()
  {
    return _wrappedBeverage.Cost() + 0.60f; 
  }
}
