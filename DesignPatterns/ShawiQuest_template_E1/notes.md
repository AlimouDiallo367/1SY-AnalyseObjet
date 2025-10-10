using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(int delta, int healthPoints);
}

interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(int delta);
}

// ========================
//        OBSERVERS
// ========================

class HealthBar : IObserver
{
    public void Update(int delta, int healthPoints)
    {
        if (delta < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[HealthBar] Vie restante : {healthPoints} (-{-delta})");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[HealthBar] Vie restante : {healthPoints} (+{delta})");
        }
        Console.ResetColor();
    }
}

class SoundManager : IObserver
{
    public void Update(int delta, int healthPoints)
    {
        if (delta < 0)
        {
            Console.WriteLine("[SoundManager] 💥 Son de blessure !");
        }
        else
        {
            Console.WriteLine("[SoundManager] ✨ Son de guérison !");
        }
    }
}

class AICompanion : IObserver
{
    private Player player;

    public AICompanion(Player p)
    {
        player = p;
    }

    public void Update(int delta, int healthPoints)
    {
        if (healthPoints <= 30)
        {
            Console.WriteLine("[AICompanion] ⚕️ Vie basse détectée, je soigne le joueur !");
            player.Heal(); // L'AI agit automatiquement
        }
    }
}

// ========================
//        SUBJECT
// ========================

class Player : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private static Random random = new Random();

    public string Name { get; set; }
    public int HealthPoints { get; private set; } = 100;
    public bool IsDead => HealthPoints <= 0;

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
        foreach (var obs in observers)
        {
            obs.Update(delta, HealthPoints);
        }
    }

    public void TakesDamage()
    {
        if (IsDead) return;

        int damage = random.Next(10, 41);
        HealthPoints -= damage;
        if (HealthPoints < 0) HealthPoints = 0;

        Notify(-damage);

        if (IsDead)
        {
            Console.WriteLine($"{Name} est mort 💀");
        }
    }

    public void Heal()
    {
        if (IsDead) return;

        int heal = random.Next(5, 21);
        HealthPoints += heal;
        if (HealthPoints > 100) HealthPoints = 100;

        Notify(heal);
    }
}

// ========================
//         TEST
// ========================

class Program
{
    static void Main()
    {
        Player player = new Player("Hero");

        HealthBar healthBar = new HealthBar();
        SoundManager soundManager = new SoundManager();
        AICompanion ai = new AICompanion(player);

        player.Attach(healthBar);
        player.Attach(soundManager);
        player.Attach(ai);

        Console.WriteLine("=== Jeu démarré ===");
        Console.WriteLine("Appuie sur 'd' pour infliger des dégâts, 'h' pour soigner, 'q' pour quitter.");

        while (!player.IsDead)
        {
            char input = Console.ReadKey(true).KeyChar;
            if (input == 'd') player.TakesDamage();
            else if (input == 'h') player.Heal();
            else if (input == 'q') break;
        }

        Console.WriteLine("=== Fin du jeu ===");
    }
}
