public abstract class Beverage
{
  private string? _description; 
  private float gst = 0.05f; 
  private float qst = 0.0975f; 
  private float extraPrices;
  public Beverage(int chocolate, int steamedMilk, int whippedCream)
  {
    extraPrices = 0.30f * steamedMilk + 0.6f * chocolate + 1.1f * whippedCream; 
  }

  public abstract float Cost();
  public abstract string GetDescription();
  public float Total() 
  {
    return (gst + qst) * Cost() + Cost() + extraPrices;
  }

  public override string ToString()
  {
    return $"Café {GetDescription()} vendu: {Total():C}"; 
  }
}
