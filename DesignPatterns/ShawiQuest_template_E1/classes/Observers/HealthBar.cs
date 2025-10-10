class HealthBar : IObserver 
{
  public void Update(int delta, int healthPoints)
  {
    if (delta < 0)
    {
      Console.WriteLine($"Red Health Bar: {healthPoints} (Lost {-delta} HP)");
    }
    else 
    {
      Console.WriteLine($"Green Health Bar: {healthPoints} (Gained {delta} HP)");
    }
  }
}
