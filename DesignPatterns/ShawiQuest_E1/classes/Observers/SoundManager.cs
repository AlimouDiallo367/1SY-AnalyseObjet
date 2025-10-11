class SoundManager : IObserver
{
  public void Update(int delta, int healthPoints)
  {
    if (delta < 0)
    {
      Console.WriteLine($"Play Hurt Sound!");
    }
    else 
    {
      Console.WriteLine($"Play Heal Sound!");
    }
  }
}
