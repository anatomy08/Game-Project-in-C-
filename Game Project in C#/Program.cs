

using Challenged;
using GameDev2_No_Bonus;
using System.ComponentModel;
using System.Diagnostics.Metrics;

Console.WriteLine("Welcome Player"); // Input Player Name
Console.Write($"Enter Name:");
string Player = Console.ReadLine();
Player User = new Player(Player);
Console.WriteLine($"Welcome {Player} Prepare to Fight");

Melee meleefighter = new Melee(); // create an enemy Orc with 120 of HP
Console.WriteLine("You will be fighting a Melee type monster which is " + meleefighter.Name + " and have " + meleefighter.Health + " of HP");



void Gameloop()
{
    int round = 1;

    while (User.Health >= 0 && meleefighter.Health >= 0)
    {
        Console.WriteLine($"Round {round}");
        Console.WriteLine($"Select Move");

        for (int i = 0; i < User.Attacklist.Count; i++)
        {
            Console.WriteLine($"{i} -- {User.Attacklist[i].Name}");
        }

        Console.WriteLine("Type your number of choice");
        string choice = Console.ReadLine();
        if (Int32.TryParse(choice, out int j))
        {
            if (j < User.Attacklist.Count && j > -1)
            {


                User.PerformAttack(meleefighter, User.Attacklist[j]);
                if (User.Attacklist[j].Name == "Ultimate")
                {
                    User.AddDamage(500);
                }

            }
            else Console.WriteLine("Invalid Choice");

            if (meleefighter.Health <= 0)
            {

                Console.WriteLine($"meeleefighter Health:{meleefighter.Health}");
                break;
            }
        }



        Attack rand = meleefighter.RandomAttack();
        meleefighter.PerformAttack(User, rand);
        Console.WriteLine($"Results of Round {round}");
        Console.WriteLine($"Player's Health:{User.Health}");
        Console.WriteLine($"Enemy's Health:{meleefighter.Health}");
        if (User.Health <= 0)
        {
            Console.WriteLine($"User Health:{User.Health}");
            break;
        }
        round++;

    }

}

Gameloop();
Checkresult();

void Checkresult()
{
    if (User.Health <= 0)
    {
        Console.WriteLine("You Lose the Game");
    }
    else
    {
        Console.WriteLine("You've Won the Game");
    }

    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Yes");
    Console.WriteLine("No");
    string playagain = Console.ReadLine();

    if (playagain.ToLower() == "yes" || playagain.ToLower() == "no")
    {
        User.Resethealth();
        meleefighter.Resethealth();
        Gameloop();
        Checkresult();
    }

    else
    {
        Console.WriteLine("Thank you for playing my game. GOODBYE!!!");
    }
}



