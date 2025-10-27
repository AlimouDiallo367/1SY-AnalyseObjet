public abstract class CondimentDecorator : Beverage
{
  protected Beverage _wrappedBeverage;

  public CondimentDecorator(Beverage wrappedBeverage)
  {
    _wrappedBeverage = wrappedBeverage;
  }

  public override abstract float Cost();
  public override abstract string GetDescription();
}
