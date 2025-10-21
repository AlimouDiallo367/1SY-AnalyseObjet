
static void RunLoop()
{
    Console.WriteLine("\nPress 'd' to take damage, 'h' to heal, or 'q' to quit:");
    while (true)
    {
        char input = Console.ReadKey(true).KeyChar;

        if (input == 'd')
        {
            //player.TakesDamage();
        }
        else if (input == 'h')
        {
            //player.Heal();
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
