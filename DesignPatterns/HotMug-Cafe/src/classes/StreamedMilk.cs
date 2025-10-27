public class StreamedMilk : CondimentDecorator
{
  public StreamedMilk(Beverage beverage) : base(beverage) 
  {
  }
  public override string GetDescription()
  {
    return _wrappedBeverage.GetDescription() + " avec lait moussé";  
  }
  public override float Cost()
  {
    return _wrappedBeverage.Cost() + 0.30f; 
  }
}
