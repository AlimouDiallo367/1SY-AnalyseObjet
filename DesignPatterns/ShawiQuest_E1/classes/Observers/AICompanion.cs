class AICompanion : IObserver
{
    private Player _player;

    public AICompanion(Player p)
    {
       _player = p; 
    }

    public void Update(int delta, int healthPoints)
    {
      if (healthPoints <= 30)
      {
         Console.WriteLine("AICompanion: Healing you!");
         _player.Heal();
      }
    }
}
