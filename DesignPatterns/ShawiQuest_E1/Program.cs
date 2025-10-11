
static void RunLoop()
{
    // Instancier le joeur en premier 
    Player player = new Player("Alimou");
    
    // Instancier les observateurs passifs (HealthBar & SoundManager
    HealthBar healthBar = new HealthBar(); 
    SoundManager soundManager = new SoundManager(); 

    // Attacher l'observation de ces deux objets 
    player.Attach(healthBar);
    player.Attach(soundManager);

    // Instancier le AICompanion en lui passant le joueur 
    AICompanion ai = new AICompanion(player);
    player.Attach(ai);

    Console.WriteLine("\nPress 'd' to take damage, 'h' to heal, or 'q' to quit:");
    while (!player.IsPlayerDead)
    {
        char input = Console.ReadKey(true).KeyChar;

        if (input == 'd')
        {
            player.TakesDamage();
        }
        else if (input == 'h')
        {
            player.Heal();
        }
        else if (input == 'q')
        {
            break;
        }
        Console.WriteLine();
    }

    Console.WriteLine("Game Over!");
}

RunLoop();
