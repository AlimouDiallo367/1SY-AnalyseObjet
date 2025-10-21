public abstract class Beverage
{
  private string? _description; 
  private float gst = 0.05f;
  private float qst = 0.0975f; 
  public float extraPrices { get; set;}

  public Beverage()
  {
    
  }

  public abstract float Cost();
  public abstract string GetDescription();
  public float Total() 
  {
    return (gst + qst) * (Cost()+extraPrices) + Cost() + extraPrices;
  }

  public override string ToString()
  {
    return $"Café {GetDescription()} vendu: {Total():C}"; 
  }
}
