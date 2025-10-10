class Player : ISubject  
{
  private List<IObserver> observers = new List<IObserver>();
  public int HealthPoints { get; set; } = 100;
  public string? Name { get; set; }
  public bool IsPlayerDead { get { return HealthPoints <= 0;} }
  private static Random random = new Random();

  public Player(string name)
  {
     Name = name; 
  }

  public void Attach(IObserver observer)
  {
    observers.Add(observer);
  }

  public void Detach(IObserver observer)
  {
    observers.Remove(observer);
  }

  public void Notify(int delta)
  {
    foreach (var eachObs in observers)
    {
       eachObs.Update(delta, HealthPoints); 
    } 
  }

  public void TakesDamage()
  {
    if (IsPlayerDead) return;

    int damage = random.Next(10, 41);
    HealthPoints -= damage;

    if (HealthPoints < 0)
    {
      HealthPoints = 0;
    }

    Notify(-damage);
  }

  public void Heal()
  {
    if (IsPlayerDead) return;

    int heal = random.Next(5, 16);
    HealthPoints += heal;

    if (HealthPoints > 100)
    {
       HealthPoints = 100; 
    }

    Notify(heal);
  }
}
