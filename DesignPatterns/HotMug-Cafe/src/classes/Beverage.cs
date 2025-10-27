public abstract class Beverage
{
  private string? _description; 
  private float gst = 0.05f;
  private float qst = 0.09975f; 
 

  public Beverage()
  {
    
  }

  public abstract float Cost();
  public abstract string GetDescription();
  public float Total() 
  {
    return gst * Cost() + qst * Cost() + Cost();
  }

  public override string ToString()
  {
    return $"Café {GetDescription()} vendu: {Total():C2}"; 
  }
}
